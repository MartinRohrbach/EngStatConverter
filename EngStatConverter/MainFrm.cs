using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace EngStatConverter
{

    public partial class MainForm : Form
    {
        string NewLine = System.Environment.NewLine;

        private List<string> SelectionList = new List<string>();
        private List<int> SelectionIndexList = new List<int>();
        private List<string> ChartSelectionList = new List<string>();
        private List<string> Rows = new List<string>();

        private string headerLine;
        private bool TableFinshed;
        private int ChartType = 0;
        private bool ChartStacked = false;

        public MainForm()
        {
            InitializeComponent();
            SelectionList.Clear();
            SelectionIndexList.Clear();
            Rows.Clear();
            ChartSelectionList.Clear();

            TableFinshed = false;
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                if (File.Exists(args[1]))
                {
                    openFileDialog.FileName = args[1];
                    WriteLog("CSV File: " + openFileDialog.FileName + NewLine, true);
                    this.Text = "Eng Stats Converter - " + Path.GetFileName(openFileDialog.FileName);
                }
                else
                    MessageBox.Show("File not found");
            } 
            if (File.Exists(Path.GetDirectoryName(args[0]) + "\\Default.esc"))
            {
                WriteLog("Selected Columns:", true);
                string[] temp = System.IO.File.ReadAllLines(Path.GetDirectoryName(args[0]) + "\\Default.esc");
                foreach (string line in temp)
                {
                    SelectionList.Add(line);
                    WriteLog(line, false);
                }
            }

        }

        public void SetSelection (List<string> List)
        {
            SelectionList = List;
        }

        private void WriteLog(string entry, bool Timestamp)
        {
            if (Timestamp)
                Log.Text += DateTime.Now.ToString() + ": " + entry + NewLine;
            else
                Log.Text += "   " + entry + NewLine;

            Log.SelectionStart = Log.TextLength;
            Log.ScrollToCaret();
            Log.Refresh();
        }

        private void ChooseSourceFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                WriteLog("CSV File: " + openFileDialog.FileName + NewLine, true);
                this.Text = "Eng Stats Converter - " + Path.GetFileName(openFileDialog.FileName);
                TableFinshed = false;
            }
        }

        private void SelectColumnsBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog.FileName))
            {
                DataSelectionForm _DataSelectionForm = new DataSelectionForm();

                if (SelectionList.Count > 0)
                    _DataSelectionForm.SetSelectionList(SelectionList);

                _DataSelectionForm.SetFilename(openFileDialog.FileName);
                _DataSelectionForm.ShowDialog();

                SelectionList = _DataSelectionForm.GetSelectionList();

                WriteLog("Selected Columns:", true);
                foreach (string line in SelectionList)
                    WriteLog(line, false);

            }
            else MessageBox.Show("No valid CSV File choosen");
        }

        private void StartConversionBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog.FileName))
                if (SelectionList.Count > 0)
                {
                    WriteLog("Start Processing", true);
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        listView1.BeginUpdate();
                        listView1.ListViewItemSorter = null;
                        listView1.Clear();
                        Rows.Clear();
                        using (var stream = File.OpenRead(openFileDialog.FileName))
                        using (var reader = new StreamReader(stream))
                        {
                            var data = CsvParser.ParseHeadAndTail(reader, ',', '"');
                            var header = data.Item1;
                            var lines = data.Item2;

                            SelectionIndexList.Clear();

                            for (int i = 0; i < header.Count; i++)
                                if (SelectionList.Contains(header[i]))
                                    SelectionIndexList.Add(i);

                            WriteLog("Colums to scan: " + header.Count.ToString(), true);

                            listView1.View = View.Details;
                            listView1.GridLines = true;
                            listView1.FullRowSelect = true;

                            string[] arr = new string[SelectionList.Count + 1];

                            ListViewItem itm;
                            headerLine = "";

                            for (var i = 0; i < SelectionIndexList.Count; i++)
                            {
                                if (showValuesCB.Checked)
                                    listView1.Columns.Add(header[SelectionIndexList[i]], 100);
                                headerLine += "\"" + header[SelectionIndexList[i]] + "\",";
                            }

                            string tempLine;

                            foreach (var line in lines)
                            {
                                tempLine = "";
                                for (int i = 0; i < SelectionIndexList.Count; i++)
                                    if (line.Count > SelectionIndexList[i])
                                        if (!string.IsNullOrEmpty(line[SelectionIndexList[i]]))
                                        {
                                            arr[i] = line[SelectionIndexList[i]];
                                            tempLine += "\"" + line[SelectionIndexList[i]] + "\",";
                                        }
                                        else
                                        {
                                            arr[i] = "";
                                            tempLine += "\"" + "0" + "\",";
                                        }
                                    else
                                        arr[i] = "";
                                itm = new ListViewItem(arr);

                                if (showValuesCB.Checked)
                                    listView1.Items.Add(itm);
                                Rows.Add(tempLine);
                            }
                        }
                        listView1.EndUpdate(); ;
                        WriteLog("Processing finished", true);
                        TableFinshed = true;
                        Log.ScrollToCaret();
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                else MessageBox.Show("No Columns selected");
            else MessageBox.Show("No valid CSV File choosen");
        }

        private void ExportNewCSVBtn_Click(object sender, EventArgs e)
        {
            if (Rows.Count > 0)
            {
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".csv";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    string[] AllLines = new string[Rows.Count + 1];
                    int i = 0;

                    AllLines[0] = headerLine.Remove(headerLine.Length - 1);

                    foreach (string row in Rows)
                    {
                        i++;
                        AllLines[i] = row.Remove(row.Length - 1);
                    }
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, AllLines);

                }
            }
            else
                MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");

        }

        private void ChartBtn_Click(object sender, EventArgs e)
        {
            if (TableFinshed)
            {
                ChartSelectionForm _ChartSelectionForm = new ChartSelectionForm();

                _ChartSelectionForm.SetSelectionLists(SelectionList, ChartSelectionList);

                _ChartSelectionForm.SetChartType(ChartType, ChartStacked);

                _ChartSelectionForm.ShowDialog();

                ChartSelectionList = _ChartSelectionForm.GetChartSelectionList();

                if (_ChartSelectionForm.GetClosingAction() == 1)
                {
                    if (ChartSelectionList[0] != "Timestamp")
                        MessageBox.Show("The first Column must be the Timestamp");
                    else
                    {

                        ChartType = _ChartSelectionForm.GetChartType();
                        ChartStacked = _ChartSelectionForm.GetChartStacked();

                        ChartForm _ChartForm = new ChartForm();
                        List<string>[] ChartValue = new List<string>[ChartSelectionList.Count];

                        int ColIndex = 0;
                        foreach (ColumnHeader header in listView1.Columns)
                        {
                            if (ChartSelectionList.Contains(header.Text))
                            {
                                ChartValue[ColIndex] = new List<string>();

                                for (int RowIndex = 0; RowIndex < listView1.Items.Count; RowIndex++)
                                {
                                    ChartValue[ColIndex].Add(listView1.Items[RowIndex].SubItems[ColIndex].Text);
                                }
                                ColIndex++;
                            }
                        }
                        _ChartForm.SetChartSelectionList(ChartSelectionList);

                        string Title = this.Text;
                        Title = Title.Replace("Eng Stats Converter - ", "");
                        Title = Title.Replace(".log", "");
                        Title = Title.Replace("engineering_serverstats", "");
                        Title = Title.Replace("_", " ");

                        _ChartForm.SetChartValue(Title , ChartType, ChartStacked, ChartValue);
                        _ChartForm.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Please start conversion first.");
        }
    }

    public static class CsvParser
    {
        private static Tuple<T, IEnumerable<T>> HeadAndTail<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            var en = source.GetEnumerator();
            en.MoveNext();
            return Tuple.Create(en.Current, EnumerateTail(en));
        }

        private static IEnumerable<T> EnumerateTail<T>(IEnumerator<T> en)
        {
            while (en.MoveNext()) yield return en.Current;
        }

        public static IEnumerable<IList<string>> Parse(string content, char delimiter, char qualifier)
        {
            using (var reader = new StringReader(content))
                return Parse(reader, delimiter, qualifier);
        }

        public static Tuple<IList<string>, IEnumerable<IList<string>>> ParseHeadAndTail(TextReader reader, char delimiter, char qualifier)
        {
            return HeadAndTail(Parse(reader, delimiter, qualifier));
        }

        public static IEnumerable<IList<string>> Parse(TextReader reader, char delimiter, char qualifier)
        {
            var inQuote = false;
            var record = new List<string>();
            var sb = new StringBuilder();

            while (reader.Peek() != -1)
            {
                var readChar = (char)reader.Read();

                if (readChar == '\n' || (readChar == '\r' && (char)reader.Peek() == '\n'))
                {
                    // If it's a \r\n combo consume the \n part and throw it away.
                    if (readChar == '\r')
                        reader.Read();

                    if (inQuote)
                    {
                        if (readChar == '\r')
                            sb.Append('\r');
                        sb.Append('\n');
                    }
                    else
                    {
                        if (record.Count > 0 || sb.Length > 0)
                        {
                            record.Add(sb.ToString());
                            sb.Clear();
                        }

                        if (record.Count > 0)
                            yield return record;

                        record = new List<string>(record.Count);
                    }
                }
                else if (sb.Length == 0 && !inQuote)
                {
                    if (readChar == qualifier)
                        inQuote = true;
                    else if (readChar == delimiter)
                    {
                        record.Add(sb.ToString());
                        sb.Clear();
                    }
                    else if (char.IsWhiteSpace(readChar))
                    {
                        // Ignore leading whitespace
                    }
                    else
                        sb.Append(readChar);
                }
                else if (readChar == delimiter)
                {
                    if (inQuote)
                        sb.Append(delimiter);
                    else
                    {
                        record.Add(sb.ToString());
                        sb.Clear();
                    }
                }
                else if (readChar == qualifier)
                {
                    if (inQuote)
                    {
                        if ((char)reader.Peek() == qualifier)
                        {
                            reader.Read();
                            sb.Append(qualifier);
                        }
                        else
                            inQuote = false;
                    }
                    else
                        sb.Append(readChar);
                }
                else
                    sb.Append(readChar);
            }

            if (record.Count > 0 || sb.Length > 0)
                record.Add(sb.ToString());

            if (record.Count > 0)
                yield return record;
        }
    }

}
