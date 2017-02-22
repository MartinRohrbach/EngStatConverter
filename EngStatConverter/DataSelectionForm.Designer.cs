namespace EngStatConverter
{
    partial class DataSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoadFromFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RegExCb = new System.Windows.Forms.CheckBox();
            this.charCountTrb = new System.Windows.Forms.TrackBar();
            this.GroupingLb = new System.Windows.Forms.Label();
            this.SelectAllFsKiBBtn = new System.Windows.Forms.Button();
            this.SelectAllFsIOPsBtn = new System.Windows.Forms.Button();
            this.SearchMarkBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.TemplateSelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyTemplateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charCountTrb)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(18, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(387, 268);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(426, 306);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(61, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(505, 306);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToFileBtn.Location = new System.Drawing.Point(426, 176);
            this.SaveToFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(143, 21);
            this.SaveToFileBtn.TabIndex = 0;
            this.SaveToFileBtn.Text = "Save Template";
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "esc";
            // 
            // LoadFromFileBtn
            // 
            this.LoadFromFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFromFileBtn.Location = new System.Drawing.Point(426, 152);
            this.LoadFromFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LoadFromFileBtn.Name = "LoadFromFileBtn";
            this.LoadFromFileBtn.Size = new System.Drawing.Size(143, 21);
            this.LoadFromFileBtn.TabIndex = 3;
            this.LoadFromFileBtn.Text = "Load Template";
            this.LoadFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadFromFileBtn.Click += new System.EventHandler(this.LoadFromFileBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTb.Location = new System.Drawing.Point(82, 11);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(323, 20);
            this.SearchTb.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(193, 33);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 21);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RegExCb
            // 
            this.RegExCb.AutoSize = true;
            this.RegExCb.Checked = true;
            this.RegExCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegExCb.Location = new System.Drawing.Point(18, 38);
            this.RegExCb.Name = "RegExCb";
            this.RegExCb.Size = new System.Drawing.Size(58, 17);
            this.RegExCb.TabIndex = 6;
            this.RegExCb.Text = "RegEx";
            this.RegExCb.UseVisualStyleBackColor = true;
            // 
            // charCountTrb
            // 
            this.charCountTrb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charCountTrb.Location = new System.Drawing.Point(426, 10);
            this.charCountTrb.Maximum = 15;
            this.charCountTrb.Minimum = 3;
            this.charCountTrb.Name = "charCountTrb";
            this.charCountTrb.Size = new System.Drawing.Size(142, 45);
            this.charCountTrb.TabIndex = 7;
            this.charCountTrb.Value = 8;
            this.charCountTrb.ValueChanged += new System.EventHandler(this.charCountTrb_ValueChanged);
            // 
            // GroupingLb
            // 
            this.GroupingLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupingLb.AutoSize = true;
            this.GroupingLb.Location = new System.Drawing.Point(435, 38);
            this.GroupingLb.Name = "GroupingLb";
            this.GroupingLb.Size = new System.Drawing.Size(81, 13);
            this.GroupingLb.TabIndex = 8;
            this.GroupingLb.Text = "8 char grouping";
            this.GroupingLb.Click += new System.EventHandler(this.GroupingLb_Click);
            // 
            // SelectAllFsKiBBtn
            // 
            this.SelectAllFsKiBBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllFsKiBBtn.Location = new System.Drawing.Point(426, 232);
            this.SelectAllFsKiBBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectAllFsKiBBtn.Name = "SelectAllFsKiBBtn";
            this.SelectAllFsKiBBtn.Size = new System.Drawing.Size(143, 21);
            this.SelectAllFsKiBBtn.TabIndex = 9;
            this.SelectAllFsKiBBtn.Text = "FS Throughput";
            this.SelectAllFsKiBBtn.UseVisualStyleBackColor = true;
            this.SelectAllFsKiBBtn.Click += new System.EventHandler(this.SelectAllFsBtn_Click);
            // 
            // SelectAllFsIOPsBtn
            // 
            this.SelectAllFsIOPsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllFsIOPsBtn.Location = new System.Drawing.Point(426, 256);
            this.SelectAllFsIOPsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectAllFsIOPsBtn.Name = "SelectAllFsIOPsBtn";
            this.SelectAllFsIOPsBtn.Size = new System.Drawing.Size(142, 21);
            this.SelectAllFsIOPsBtn.TabIndex = 10;
            this.SelectAllFsIOPsBtn.Text = "FS IOP/s";
            this.SelectAllFsIOPsBtn.UseVisualStyleBackColor = true;
            this.SelectAllFsIOPsBtn.Click += new System.EventHandler(this.SelectAllFsIOPsBtn_Click);
            // 
            // SearchMarkBtn
            // 
            this.SearchMarkBtn.Location = new System.Drawing.Point(306, 33);
            this.SearchMarkBtn.Name = "SearchMarkBtn";
            this.SearchMarkBtn.Size = new System.Drawing.Size(96, 21);
            this.SearchMarkBtn.TabIndex = 11;
            this.SearchMarkBtn.Text = "Search + Mark";
            this.SearchMarkBtn.UseVisualStyleBackColor = true;
            this.SearchMarkBtn.Click += new System.EventHandler(this.SearchMarkBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(82, 33);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(96, 21);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear Sel";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // TemplateSelBox
            // 
            this.TemplateSelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateSelBox.FormattingEnabled = true;
            this.TemplateSelBox.Location = new System.Drawing.Point(426, 83);
            this.TemplateSelBox.Name = "TemplateSelBox";
            this.TemplateSelBox.Size = new System.Drawing.Size(143, 21);
            this.TemplateSelBox.TabIndex = 13;
            this.TemplateSelBox.SelectedIndexChanged += new System.EventHandler(this.TemplateSelBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Selection Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search for";
            // 
            // ApplyTemplateBtn
            // 
            this.ApplyTemplateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyTemplateBtn.Enabled = false;
            this.ApplyTemplateBtn.Location = new System.Drawing.Point(426, 107);
            this.ApplyTemplateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ApplyTemplateBtn.Name = "ApplyTemplateBtn";
            this.ApplyTemplateBtn.Size = new System.Drawing.Size(143, 21);
            this.ApplyTemplateBtn.TabIndex = 16;
            this.ApplyTemplateBtn.Text = "Apply Template";
            this.ApplyTemplateBtn.UseVisualStyleBackColor = true;
            this.ApplyTemplateBtn.Click += new System.EventHandler(this.ApplyTemplateBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Values for Top Talker stats";
            // 
            // DataSelectionForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApplyTemplateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemplateSelBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SearchMarkBtn);
            this.Controls.Add(this.SelectAllFsIOPsBtn);
            this.Controls.Add(this.SelectAllFsKiBBtn);
            this.Controls.Add(this.GroupingLb);
            this.Controls.Add(this.charCountTrb);
            this.Controls.Add(this.RegExCb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.LoadFromFileBtn);
            this.Controls.Add(this.SaveToFileBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.treeView1);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "DataSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Selection";
            this.Load += new System.EventHandler(this.DataSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charCountTrb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveToFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LoadFromFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.CheckBox RegExCb;
        private System.Windows.Forms.TrackBar charCountTrb;
        private System.Windows.Forms.Label GroupingLb;
        private System.Windows.Forms.Button SelectAllFsKiBBtn;
        private System.Windows.Forms.Button SelectAllFsIOPsBtn;
        private System.Windows.Forms.Button SearchMarkBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox TemplateSelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyTemplateBtn;
        private System.Windows.Forms.Label label3;
    }
}