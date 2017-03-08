using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Microsoft.Win32;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;

namespace EngStatConverter
{

    public partial class MainForm : Form
    {
        string NewLine = System.Environment.NewLine;

        private List<string> SelectionList = new List<string>();
        private List<string> ChartSelectionList = new List<string>();
        
        private bool TableFinshed;
        private int ChartType = 0;
        private bool ChartStacked = false;
        private string CSVFileName;
        private string StartDir;
        private int DefaultSelectionListCount;
        private bool ExcelFound;
        private string ExcelPath;
        private ProgressDialog progressDialog;
        List<string> ListViewHeader = new List<string>();
        List<List<string>> ListViewData = new List<List<String>>();

        public MainForm()
        {
            InitializeComponent();
            SelectionList.Clear();
            ChartSelectionList.Clear();

            TableFinshed = false;
            string[] args = Environment.GetCommandLineArgs();

            StartDir = Path.GetDirectoryName(args[0]);
            if (StartDir != "")
                StartDir = StartDir + "\\";

            if (args.Length > 1)
            {
                if (File.Exists(args[1]))
                {
                    CSVFileName = args[1];
                    WriteLog("CSV File: " + CSVFileName + NewLine, true);
                    this.Text = "Eng Stats Converter - " + Path.GetFileName(CSVFileName);
                }
                else
                    MessageBox.Show("File not found");

            }

            // Cmd Line Automation
            if (args.Length >= 2)
            {

                if (args[2].ToUpper() == "/AUTO")
                {

                    if (File.Exists(StartDir + "SelectionTemplates\\" + args[3]))
                    {

                        
                        // Load Selection Template
                        string[] temp = System.IO.File.ReadAllLines(StartDir + "SelectionTemplates\\" + args[3]);
                        foreach (string line in temp)
                        {
                            SelectionList.Add(line);
                            WriteLog(line, false);
                        }

                        Console.WriteLine(SelectionList.Count.ToString());

                        // Start Conversion
                        backgroundWorkerConversion.RunWorkerAsync();
                        using (progressDialog = new ProgressDialog())
                        {
                            progressDialog.ShowDialog(this);
                        }
                        progressDialog = null;
                        if (backgroundWorkerConversion.IsBusy) backgroundWorkerConversion.CancelAsync();

                        // Save CSV                        
                        ExportNewCSV(Path.GetDirectoryName(CSVFileName)+"\\"+ Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(CSVFileName)) + ".csv");
                    }
                    else
                        MessageBox.Show("Selection Template not found");
                }
                else
                    MessageBox.Show("Wrong Parameter");

                MessageBox.Show("Ende");
                System.Environment.Exit(1);
            }

            if (File.Exists(StartDir + "SelectionTemplates\\Default.esc"))
            {
                WriteLog("Selected Columns:", true);
                string[] temp = System.IO.File.ReadAllLines(StartDir + "SelectionTemplates\\Default.esc");
                foreach (string line in temp)
                {
                    SelectionList.Add(line);
                    WriteLog(line, false);
                }
                DefaultSelectionListCount = SelectionList.Count;
            } else DefaultSelectionListCount = -1;

            if (File.Exists(StartDir + "ExcelTemplates\\PerfAnalyseTemplate.xlsm"))
                ExcelFound = true;
            else
                ExcelFound = false;

            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\excel.exe"))
                {
                    if (key != null)
                    {
                        ExcelPath = key.GetValue("Path").ToString() + "excel.exe";
                    }
                    else
                        ExcelFound = false;
                }
            }
            catch (Exception ex)
            {
                ExcelFound = false;
            }

            SetButtonStatus();

        }

        delegate void SetButtonStatusDelegate();

        private void SetButtonStatus()
        {
            if (this.InvokeRequired)
            {
                SetButtonStatusDelegate invoker = new SetButtonStatusDelegate(SetButtonStatus);
                this.Invoke(invoker, new object[] {});
            } else { 
                PerfExcelBtn.Enabled = (ExcelFound) & (ListViewData.Count > 0);
                ExcelBtn.Enabled = (ExcelFound) & (ListViewData.Count > 0);
                TTExcelBtn.Enabled = (ExcelFound) & (ListViewData.Count > 0);
                StartConversionBtn.Enabled = (File.Exists(CSVFileName)) & (SelectionList.Count > 0);
                ExportNewCSVBtn.Enabled = (ListViewData.Count > 0);
                SelectColumnsBtn.Enabled = (File.Exists(CSVFileName));
                ChartBtn.Enabled = TableFinshed;
            }
        }

        public void SetSelection (List<string> List)
        {
            SelectionList = List;
        }

        private void ChooseSourceFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                ChooseSourceFile(openFileDialog.FileName);
            }
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
                            if (ChartSelectionList.Contains(header.Text) | ChartSelectionList.Contains("-" + header.Text))
                            {
                                ChartValue[ColIndex] = new List<string>();

                                for (int RowIndex = 0; RowIndex < listView1.Items.Count; RowIndex++)
                                {
                                    ChartValue[ColIndex].Add(listView1.Items[RowIndex].SubItems[header.Index].Text);
                                }
                                ColIndex++;                              
                            }
                            
                        }
                        _ChartForm.SetChartSelectionList(ChartSelectionList);

                        string Title = this.Text;
                        Title = Title.Replace("Eng Stats Converter - ", "");
                        Title = Title.Replace(".log", "");
                        Title = Title.Replace(".csv", "");
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

        private void SelectColumnsBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(CSVFileName))
            {
                DataSelectionForm _DataSelectionForm = new DataSelectionForm();

                if (SelectionList.Count > 0)
                    _DataSelectionForm.SetSelectionList(new List<String>(SelectionList));

                _DataSelectionForm.SetFilename(CSVFileName);
                _DataSelectionForm.ShowDialog();

                List<String> newSelectionList = _DataSelectionForm.GetSelectionList();

                if (newSelectionList.SequenceEqual(SelectionList) && ListViewData.Count > 0)
                {
                    WriteLog("No change in columns.", false);
                } else {
                    if (newSelectionList.Count > 100)
                    {
                        MessageBox.Show("The selection contains more than 100 columns, only the first 100 will be display inline. A CSV export will however contain all columns.");
                    }

                    SelectionList = newSelectionList;

                    WriteLog("Selected Columns:", true);

                    var lines = new StringBuilder();
                    foreach (string line in SelectionList)
                    {
                        lines.Append(line);
                        lines.Append(Environment.NewLine);
                    }
                    WriteLog(lines.ToString(), false);

                    StartConversionBtn_Click(sender, e);
                }
            }
            else MessageBox.Show("No valid CSV File choosen");
        }

        private void StartConversionBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(CSVFileName))
            {
                MessageBox.Show("No valid CSV File choosen");
                return;
            }
            if (SelectionList.Count <= 0)
            {
                MessageBox.Show("No Columns selected");
            }

            backgroundWorkerConversion.RunWorkerAsync();
            using (progressDialog = new ProgressDialog())
            {
                progressDialog.ShowDialog(this);
            }
            progressDialog = null;
            if (backgroundWorkerConversion.IsBusy) backgroundWorkerConversion.CancelAsync();
        }

        private void ExportNewCSVBtn_Click(object sender, EventArgs e)
        {
            if (ListViewData.Count > 0)
            {
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(CSVFileName)) + ".csv";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                    ExportNewCSV(saveFileDialog.FileName);
            }
            else
                MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutFrm _AboutFrm = new AboutFrm();
            _AboutFrm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ChooseSourceFile(files[0]);
        }

        private void ExportNewCSV(string FileName)
        {
            if (FileName != "")
            {
                System.IO.StreamWriter Stream = new System.IO.StreamWriter(FileName);
                Stream.WriteLine("\"" + string.Join("\",\"", ListViewHeader) + "\"");
                foreach (List<string> Row in ListViewData)
                {
                    Stream.WriteLine("\"" + string.Join("\",\"", Row) + "\"");
                }
                Stream.Close();
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void ChooseSourceFile(string Filename)
        {
            if (File.Exists(Filename))
            {
                WriteLog("CSV File: " + Filename + NewLine, true);
                CSVFileName = Filename;
                this.Text = "Eng Stats Converter - " + Path.GetFileName(Filename);
                TableFinshed = false;
                ListViewHeader.Clear();
                listView1.VirtualListSize = 0;
                listView1.Columns.Clear();
                ListViewData.Clear();
                SetButtonStatus();
            }
        }

        delegate void WriteLogDelegate(string entry, bool Timestamp);

        private void WriteLog(string entry, bool Timestamp)
        {
            if (this.InvokeRequired)
            {
                WriteLogDelegate invoker = new WriteLogDelegate(WriteLog);
                this.Invoke(invoker, new object[] { entry, Timestamp });
            }
            else
            {
                if (Timestamp)
                    Log.Text += DateTime.Now.ToString() + ": " + entry + NewLine;
                else
                    Log.Text += "   " + entry + NewLine;

                Log.SelectionStart = Log.TextLength;
                Log.ScrollToCaret();
                Log.Refresh();
            }
        }

        private void backgroundWorkerConversion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<int> SelectionIndexList = new List<int>();

            listView1.Invoke((MethodInvoker)delegate
            {
                listView1.BeginUpdate();
                listView1.Columns.Clear();
                listView1.VirtualListSize = 0;
            });

            WriteLog("Start Processing", true);
            
            String filename = CSVFileName;
            Stream stream = File.OpenRead(filename);
            if (filename.EndsWith("gz"))
            {
                stream = new GZipStream(stream, System.IO.Compression.CompressionMode.Decompress);
            }
            using (var reader = new StreamReader(stream))
            {
                var data = CsvParser.ParseHeadAndTail(reader, ',', '"');
                var header = data.Item1;
                var lines = data.Item2;

                ListViewHeader.Clear();
                ListViewData.Clear();

                // filter the available columns by the ones selected in the GUI and store the index
                // and the column names for the actual list, also create the header line
                for (int i = 0; i < header.Count; i++)
                    if (SelectionList.Contains(header[i]))
                    {
                        SelectionIndexList.Add(i);
                        ListViewHeader.Add(header[i]);
                    }

                WriteLog("Colums to scan: " + header.Count.ToString(), true);

                // Now go through the lines and build both the CSV output and the content of
                // the listview
                int linecount = 0;
                foreach (var line in lines)
                {
                    if (backgroundWorkerConversion.CancellationPending)
                    {
                        break;
                    }
                    List<String> SelectionRow = new List<string>();

                    foreach (var Index in SelectionIndexList)
                    {
                        if (line.Count > Index && !string.IsNullOrEmpty(line[Index]))
                        {
                            SelectionRow.Add(line[Index]);
                        }
                        else
                        {
                            SelectionRow.Add("0");
                        }
                    }

                    ListViewData.Add(SelectionRow);

                    if ((linecount++ % 100) == 0)
                    {
                        int progress = (linecount / 100) % 100;
                        worker.ReportProgress(progress);
                    }
                }
            }
            
            if (backgroundWorkerConversion.CancellationPending)
            {
                e.Cancel = true;
            }
            listView1.Invoke((MethodInvoker)delegate
            {
                foreach (var Header in ListViewHeader.GetRange(0,ListViewHeader.Count > 100 ? 100 : ListViewHeader.Count))
                {
                    listView1.Columns.Add(Header, 100);
                }
                listView1.VirtualListSize = ListViewData.Count;
                listView1.EndUpdate();
            });

            WriteLog("Processing finished", true);
            TableFinshed = true;
            SetButtonStatus();
        }

        private void backgroundWorkerConversion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressDialog != null) progressDialog.Close();
        }

        private void backgroundWorkerConversion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressDialog != null) progressDialog.ShowProgress(e.ProgressPercentage);
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(ListViewData[e.ItemIndex].ToArray());
        }

        private void PerfExcelBtn_Click(object sender, EventArgs e)
        {
            if (ListViewData.Count > 0)
            {
                if (SelectionList.Count == DefaultSelectionListCount)
                {
                    try
                    {
                        string TempCSVFileName;
                        TempCSVFileName = Path.GetTempPath() + Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(CSVFileName)) + ".csv";
                        ExportNewCSV(TempCSVFileName);

                        if (File.Exists(StartDir + "ExcelTemplates\\PerfAnalyseTemplate.xlsm"))
                        {
                            // Crap. The /e params cannot contain blanks. Hmpf. Use double \\ to mask them
                            TempCSVFileName = TempCSVFileName.Replace(" ", "\\\\");
                            Process p = new Process();
                            p.StartInfo.FileName = ExcelPath;
                            p.StartInfo.Arguments = "\"" + StartDir + "ExcelTemplates\\PerfAnalyseTemplate.xlsm\" /e/" + TempCSVFileName;
                            p.Start();
                        }
                        else MessageBox.Show("Excel Template not found");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot generate the Performance Excel Chart: " + ex);
                    }

                }
                else MessageBox.Show("Column Selection was changed from default");
            }
            else MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            if (ListViewData.Count > 0)
            {
                try
                {
                    string TempCSVFileName;
                    TempCSVFileName = Path.GetTempPath() + Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(CSVFileName)) + ".csv";
                    ExportNewCSV(TempCSVFileName);

                    if (File.Exists(StartDir + "ExcelTemplates\\Template.xlsm"))
                    {
                        // Crap. The /e params cannot contain blanks. Hmpf. Use double \\ to mask them
                        TempCSVFileName = TempCSVFileName.Replace(" ", "\\\\");
                        Process p = new Process();
                        p.StartInfo.FileName = ExcelPath;
                        p.StartInfo.Arguments = "\"" + StartDir + "ExcelTemplates\\Template.xlsm\" /e/" + TempCSVFileName;
                        p.Start();
                    }
                    else MessageBox.Show("Excel Template not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot generate the Performance Excel Chart: " + ex);
                }
            }
            else MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");

        }

        private void TTExcelBtn_Click(object sender, EventArgs e)
        {
            if (ListViewData.Count > 0)
            {
                try
                {
                    string TempCSVFileName;
                    TempCSVFileName = Path.GetTempPath() + Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(CSVFileName)) + ".csv";
                    ExportNewCSV(TempCSVFileName);

                    if (File.Exists(StartDir + "ExcelTemplates\\TTTemplate.xlsm"))
                    {
                        // Crap. The /e params cannot contain blanks. Hmpf. Use double \\ to mask them
                        TempCSVFileName = TempCSVFileName.Replace(" ", "\\\\");
                        Process p = new Process();
                        p.StartInfo.FileName = ExcelPath;
                        p.StartInfo.Arguments = "\"" + StartDir + "ExcelTemplates\\TTTemplate.xlsm\" /e/" + TempCSVFileName;
                        p.Start();
                    }
                    else MessageBox.Show("Excel Template not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot generate the Performance Excel Chart: " + ex);
                }
            }
            else MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");
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
