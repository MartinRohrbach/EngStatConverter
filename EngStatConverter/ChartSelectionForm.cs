using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EngStatConverter
{
    public partial class ChartSelectionForm : Form
    {

        List<string> ChartSelectionList = new List<string>();
        List<string> SelectionList = new List<string>();
        private int Closing_Action;
        private int ChartType;
        private bool ChartStacked;

        public List<string> GetChartSelectionList()
        {
            return ChartSelectionList;
        }

        public void SetSelectionLists(List<string> list_a, List<string> list_b)
        {
            SelectionList = list_a;
            ChartSelectionList = list_b;
        }

        public int GetClosingAction()
        {
            return Closing_Action;
        }

        public void SetChartType(int Type, bool Stacked)
        {
            ChartType = Type;
            ChartStacked = Stacked;
        }

        public int GetChartType()
        {
            return ChartType;
        }

        public bool GetChartStacked()
        {
            return ChartStacked;
        }

        public ChartSelectionForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Closing_Action = 0;
            Close();
        }

        private void CreateChartBtn_Click(object sender, EventArgs e)
        {         
            ChartSelectionList.Clear();
            ChartSelectionList.Add("Timestamp");
            for (int i = 0; i < ChartSelectionChLbAxis1.Items.Count; i++)
            {
                if (ChartSelectionChLbAxis1.GetItemChecked(i))
                    ChartSelectionList.Add(ChartSelectionChLbAxis1.Items[i].ToString());
                if (ChartSelectionChLbAxis2.GetItemChecked(i))
                    ChartSelectionList.Add("-" + ChartSelectionChLbAxis2.Items[i].ToString());
            }
            Closing_Action = 1;
            Close();
        }

        private void ChartSelectionForm_Load(object sender, EventArgs e)
        {
            switch (ChartType)
            {
                case 0:
                    LineRb.Checked = true;
                    break;
                case 1:
                    BarRb.Checked = true;
                    break;
                case 2:
                    SplineRb.Checked = true;
                    break;
            }
            StackedCb.Checked = ChartStacked;

            foreach (string SelectionItem in SelectionList)
            {
                if (SelectionItem != "Timestamp")
                {
                    ChartSelectionChLbAxis1.Items.Add(SelectionItem);
                    ChartSelectionChLbAxis2.Items.Add(SelectionItem);
                    if (ChartSelectionList.Contains(SelectionItem) | SelectionItem == "Timestamp")
                        ChartSelectionChLbAxis1.SetItemChecked(ChartSelectionChLbAxis1.Items.Count - 1, true);
                    else
                        ChartSelectionChLbAxis1.SetItemChecked(ChartSelectionChLbAxis1.Items.Count - 1, false);
                    if (ChartSelectionList.Contains("-" + SelectionItem))
                        ChartSelectionChLbAxis2.SetItemChecked(ChartSelectionChLbAxis2.Items.Count - 1, true);
                    else
                        ChartSelectionChLbAxis2.SetItemChecked(ChartSelectionChLbAxis2.Items.Count - 1, false);
                }

            }
        }

        private void ChartTypeChange(object sender, EventArgs e)
        {
            if (LineRb.Checked)
                ChartType = 0;
            else if (BarRb.Checked)
                ChartType = 1;
            else
                ChartType = 2;

            ChartStacked = StackedCb.Checked;
            
        }

        private void ChartSelectionChLbAxis1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                ChartSelectionChLbAxis2.SetItemChecked(e.Index, false);
        }

        private void ChartSelectionChLbAxis2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                ChartSelectionChLbAxis1.SetItemChecked(e.Index, false);
        }

        private void ClearSelectionBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ChartSelectionChLbAxis1.Items.Count; i++)
            {
                ChartSelectionChLbAxis1.SetItemChecked(i, false);
                ChartSelectionChLbAxis2.SetItemChecked(i, false);
            }
        }
    }
}
