using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace EngStatConverter
{
    public partial class ChartForm : Form
    {

        List<string> ChartSelectionList = new List<string>();
        List<string>[] ChartValue;
        private string ChartTitle;
        private int ChartType =0 ;
        private bool ChartStacked = false;
        private DateTime ChartMin;
        private DateTime ChartMax;

        public ChartForm()
        {
            InitializeComponent();
        }

        public void SetChartSelectionList(List<string> selList)
        {
            ChartSelectionList= selList;
        }

        public void SetChartValue(string Title, int Type, bool Stacked, List<string>[] Values)
        {
            ChartValue = Values;
            ChartTitle = Title;
            ChartType = Type;
            ChartStacked = Stacked;
        }

        private void GenerateChart()
        {
            try
            {
                chart.Series.Clear();
                SetupChartArea(chart);
                chart.Titles.Add(ChartTitle);
                for (int i = 1; i < ChartValue.Count(); i++)
                {
                    NewSeries(chart, ChartSelectionList[i], ChartValue[0], ChartValue[i]);
                }
                LeftAxisMaxTb.Text = "";
                RightAxisMaxTb.Text = "";

                ChartMin = DateTime.ParseExact(ChartValue[0][0], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                ChartMax = DateTime.ParseExact(ChartValue[0][ChartValue[0].Count - 1], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            }
            finally
            {
                
            }
        }

        private void NewSeries(Chart chart, string name, List<string> Timestamps, List<string> ValuePoints)
        {
            if (name.StartsWith("-"))
                name = name.Remove(0, 1) + " (right axis)";
            else
                name = name + " (left axis)";

            chart.Series.Add(name);
            int Index = chart.Series.Count - 1;
            chart.Series[Index].XValueType = ChartValueType.DateTime;

            if (name.EndsWith("(right axis)"))
                chart.Series[Index].YAxisType = AxisType.Secondary;
            else
                chart.Series[Index].YAxisType = AxisType.Primary;



            switch (ChartType)
            {
                case 0:
                    if (ChartStacked)
                        chart.Series[Index].ChartType = SeriesChartType.StackedArea;
                    else
                        chart.Series[Index].ChartType = SeriesChartType.Line;
                    break;
                case 1:
                    if (ChartStacked)
                        chart.Series[Index].ChartType = SeriesChartType.StackedColumn;
                    else
                        chart.Series[Index].ChartType = SeriesChartType.StackedColumn;
                    break;
                case 2:
                    if (ChartStacked)
                        chart.Series[Index].ChartType = SeriesChartType.SplineArea;
                    else
                        chart.Series[Index].ChartType = SeriesChartType.Spline;
                    break;              
            }

            System.DateTime x = new DateTime();

            for (int i = 0; i < Timestamps.Count; i++)
            {
                try
                {
                    x = DateTime.ParseExact(Timestamps[i].ToString(), "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    chart.Series[Index].Points.AddXY(x.ToOADate(), Int32.Parse(ValuePoints[i].ToString()));
                }
                catch
                {

                }
            }
        }

        private void ChartForm_Load(object sender, EventArgs e)
        { 
            GenerateChart();
        }

        public void SetupChartArea(Chart chart)
        {
            chart.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep90;
            chart.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Auto;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8, System.Drawing.FontStyle.Regular);
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM - HH:mm:ss";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }
        }

        private void AxisMaxTb_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            int max;
            if (int.TryParse(LeftAxisMaxTb.Text, out max))
                chart.ChartAreas[0].AxisY.Maximum = max;
            else
                chart.ChartAreas[0].AxisY.Maximum = Double.NaN;

            if (int.TryParse(RightAxisMaxTb.Text, out max))
                chart.ChartAreas[0].AxisY2.Maximum = max;
            else
                chart.ChartAreas[0].AxisY2.Maximum = Double.NaN; 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            ChartMin = (DateTime.FromOADate(chart.ChartAreas[0].AxisX.PixelPositionToValue(ChartContextMenu.Left - Left - 20)));
            chart.ChartAreas[0].AxisX.Minimum = chart.ChartAreas[0].AxisX.PixelPositionToValue(ChartContextMenu.Left - Left - 20);
        }

        private void SetEndTimeCMI_Click(object sender, EventArgs e)
        {
            ChartMax = (DateTime.FromOADate(chart.ChartAreas[0].AxisX.PixelPositionToValue(ChartContextMenu.Left - Left - 20)));
            chart.ChartAreas[0].AxisX.Maximum = chart.ChartAreas[0].AxisX.PixelPositionToValue(ChartContextMenu.Left - Left - 20);
        }

        private void ResetTimeFilterCMI_Click(object sender, EventArgs e)
        {
            System.DateTime x = new DateTime();

            x = DateTime.ParseExact(ChartValue[0][ChartValue[0].Count - 1], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            chart.ChartAreas[0].AxisX.Maximum = x.ToOADate();

            x = DateTime.ParseExact(ChartValue[0][0], "yyyy/MM/dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            chart.ChartAreas[0].AxisX.Minimum = x.ToOADate();

        }
    }
}
