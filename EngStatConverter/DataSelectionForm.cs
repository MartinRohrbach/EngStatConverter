﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace EngStatConverter
{
    public partial class DataSelectionForm : Form
    {
        List<string> selectionList = new List<string>();
        string StartDir;

        public List<string> GetSelectionList()
        {
            return selectionList;
        }

        public void SetSelectionList(List<string> list)
        {
            selectionList = list;            
        }

        private string CSVFilename;

        public DataSelectionForm()
        {
            InitializeComponent();
        }

        private void DataSelection_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            StartDir = Path.GetDirectoryName(args[0]);

            string[] TemplateFiles = { };
            try
            {
                TemplateFiles = Directory.GetFiles(StartDir + "\\SelectionTemplates", "*.esc");
            }
            catch (DirectoryNotFoundException) { }

            TemplateSelBox.Items.Clear();
            foreach (string Template in TemplateFiles)
                TemplateSelBox.Items.Add(Path.GetFileNameWithoutExtension(Template));

            BuildTreeView();
        }

        public void SetFilename(string Filename)
        {
            CSVFilename = Filename;
        }

        private void BuildTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode node;
            int CharCount = charCountTrb.Value;

            Stream stream = File.OpenRead(CSVFilename);
            if (CSVFilename.EndsWith("gz"))
            {
                stream = new GZipStream(stream, System.IO.Compression.CompressionMode.Decompress);
            }
            using (var reader = new StreamReader(stream))
            {
                var data = CsvParser.ParseHeadAndTail(reader, ',', '"');
                var header = data.Item1;
                var lines = data.Item2;
                node = treeView1.Nodes.Add(header[0]);

                string Start;
                string Item = header[0];
                string ItemStart;
                string NextItem;
                string NextItemStart;

                Start = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);

                for (var i = 1; i < header.Count; i++)
                {
                    Item = header[i];
                    ItemStart = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);

                    if (i < header.Count - 1)
                    {
                        NextItem = header[i + 1];
                        NextItemStart = NextItem.Substring(0, NextItem.Length > CharCount ? CharCount : NextItem.Length);
                    }
                    else
                    {
                        NextItem = "";
                        NextItemStart = "";
                    }

                    if (Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length) == Start)
                        node.Nodes.Add(Item);
                    else
                    {
                        if (NextItemStart == ItemStart)
                        {
                            node = treeView1.Nodes.Add(Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length));
                            node.Nodes.Add(Item);
                        }
                        else
                        {
                            node = treeView1.Nodes.Add(Item);

                        }
                        Start = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);
                    }
                }

                // if (selectionList.Count > 0)
                    SetCheckStatus();

                SearchTreeView(false, SearchTb.Text);
            }
        }

        private void CreateSelectionList()
        {
            selectionList.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Checked && node.Nodes.Count == 0)
                {
                    selectionList.Add(node.Text);
                }
                foreach (TreeNode SubNode in node.Nodes)
                    if (SubNode.Checked)
                        selectionList.Add(SubNode.Text);

            }
        }

        private void SetCheckStatus()
        {
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (selectionList.Contains(item.Text) | item.Text == "Timestamp")
                    item.Checked = true;
                else
                    item.Checked = false;
                if (item.Nodes.Count > 0)
                    foreach (TreeNode subItem in item.Nodes)
                        if (selectionList.Contains(subItem.Text))
                        {
                            subItem.Checked = true;
                            subItem.Parent.Expand();
                        }
            }
            SetCheckStatusParentNode();
        }

        private void SetCheckStatusParentNode()
        {
            bool allChecked;
            foreach (TreeNode item in treeView1.Nodes)
                if (item.Nodes.Count > 0)
                {
                    allChecked = true;
                    foreach (TreeNode subNode in item.Nodes)
                        if (subNode.Checked == false)
                            allChecked = false;
                    item.Checked = allChecked;                    
                }
        }

        private void CheckSubItems(TreeNode treeNode, bool nodeChecked)
        { 
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    CheckSubItems(node, nodeChecked);
                }
            }
        }

        private void SearchTreeView(bool select, string SearchPattern)
        { 
            
            foreach (TreeNode node in treeView1.Nodes)
            {
                if ((SearchPattern != "") && RegExMatch(node.Text, SearchPattern))
                {
                    node.ForeColor = System.Drawing.Color.Red;
                    node.Checked = select;
                }
                else
                    node.ForeColor = System.Drawing.Color.Black;
                if (node.Nodes.Count > 0)
                    foreach (TreeNode subNode in node.Nodes)
                        if ((SearchPattern != "") && RegExMatch(subNode.Text, SearchPattern))
                        {
                            subNode.ForeColor = System.Drawing.Color.Red;
                            subNode.Checked = select;
                            subNode.Parent.Expand();
                        }
                        else
                            subNode.ForeColor = System.Drawing.Color.Black;
            }
        }

        private string WildcardToRegex(string pattern)
        {
            try
            {
                return "^" + Regex.Escape(pattern)
                                  .Replace(@"\*", ".*")
                                  .Replace(@"\?", ".")
                           + "$";
            }
            catch
            {
                return pattern;
            }
        }

        private bool RegExMatch(string input, string pattern)
        {
            while (pattern.Contains("**"))
                pattern = pattern.Replace("**", "*");

            if (pattern.StartsWith("*"))
                pattern = pattern.Remove(0, 1);
            
            try
            {
                Regex r = new Regex((RegExCb.Checked ? pattern : WildcardToRegex(pattern)), RegexOptions.IgnoreCase);
                return r.Match(input).Success;
            }
            catch
            {
                return false;
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    CheckSubItems(e.Node, e.Node.Checked);
                }
            }
        }

        private void SelectAllFsBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(true, "MetaVol [a-z0-9]+(_[a-z0-9]{3}|_saparch|_archive)?(_(?!_daily|prj|bck))? (Read|Write) (KiB[^ %])");
        }

        private void charCountTrb_ValueChanged(object sender, EventArgs e)
        {
            BuildTreeView();
            GroupingLb.Text = charCountTrb.Value + " char grouping";
        }

        private void GroupingLb_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllFsIOPsBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(true, "MetaVol [a-z0-9]+(_[a-z0-9]{3}|_saparch|_archive)?(_(?!_daily|prj|bck))? (Read|Write) (Ops[^ %])");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(false, SearchTb.Text);
        }

        private void SearchMarkBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(true, SearchTb.Text);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "esc";
            saveFileDialog1.InitialDirectory = "/SelectionTemplates";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                CreateSelectionList();
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, selectionList);
            }
        }

        private void LoadFromFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Selection Files|*.esc";
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
                LoadTemplate(openFileDialog1.FileName);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            CreateSelectionList();
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            selectionList.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                node.ForeColor = System.Drawing.Color.Black;
                if (node.Text != "Timestamp") node.Checked = false;
                node.Collapse(false);
                if (node.Nodes.Count > 0)
                    foreach (TreeNode subNode in node.Nodes)
                    {
                        subNode.ForeColor = System.Drawing.Color.Black;
                        subNode.Checked = false;
                    }
            }
        }

        private void ApplyTemplateBtn_Click(object sender, EventArgs e)
        {
            LoadTemplate(StartDir + "\\SelectionTemplates\\" + TemplateSelBox.SelectedItem.ToString() + ".esc");
        }

        private void LoadTemplate(string Filename)
        {
            if (File.Exists(Filename))
            {
                selectionList.Clear();
                string[] temp = System.IO.File.ReadAllLines(Filename);
                foreach (string line in temp)
                    selectionList.Add(line);
                SetCheckStatus();
                ApplyTemplateBtn.Enabled = false;
                TemplateSelBox.Text = "";
            }
        }

        private void TemplateSelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyTemplateBtn.Enabled = true;
        }
    }
}
