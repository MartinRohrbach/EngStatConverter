namespace EngStatConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Log = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TTExcelBtn = new System.Windows.Forms.Button();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.PerfExcelBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ChartBtn = new System.Windows.Forms.Button();
            this.ExportNewCSVBtn = new System.Windows.Forms.Button();
            this.StartConversionBtn = new System.Windows.Forms.Button();
            this.SelectColumnsBtn = new System.Windows.Forms.Button();
            this.ChooseSourceFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backgroundWorkerConversion = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All supported (*.log;*.log.gz;*.csv)|*.log;*.log.gz;*.csv|log|*.log|log.gz|*.log." +
    "gz|csv|*.csv";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(774, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualMode = true;
            this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // Log
            // 
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(774, 106);
            this.Log.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.AboutBtn);
            this.panel1.Controls.Add(this.ChartBtn);
            this.panel1.Controls.Add(this.ExportNewCSVBtn);
            this.panel1.Controls.Add(this.StartConversionBtn);
            this.panel1.Controls.Add(this.SelectColumnsBtn);
            this.panel1.Controls.Add(this.ChooseSourceFileBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 48);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TTExcelBtn);
            this.groupBox1.Controls.Add(this.ExcelBtn);
            this.groupBox1.Controls.Add(this.PerfExcelBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(469, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 45);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel Exports";
            // 
            // TTExcelBtn
            // 
            this.TTExcelBtn.Location = new System.Drawing.Point(81, 14);
            this.TTExcelBtn.Margin = new System.Windows.Forms.Padding(1);
            this.TTExcelBtn.Name = "TTExcelBtn";
            this.TTExcelBtn.Size = new System.Drawing.Size(65, 23);
            this.TTExcelBtn.TabIndex = 6;
            this.TTExcelBtn.Text = "TopTalker";
            this.TTExcelBtn.UseVisualStyleBackColor = true;
            this.TTExcelBtn.Click += new System.EventHandler(this.TTExcelBtn_Click);
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(152, 14);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(65, 23);
            this.ExcelBtn.TabIndex = 7;
            this.ExcelBtn.Text = "Excel";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // PerfExcelBtn
            // 
            this.PerfExcelBtn.Location = new System.Drawing.Point(10, 14);
            this.PerfExcelBtn.Name = "PerfExcelBtn";
            this.PerfExcelBtn.Size = new System.Drawing.Size(65, 23);
            this.PerfExcelBtn.TabIndex = 5;
            this.PerfExcelBtn.Text = "Standard";
            this.PerfExcelBtn.UseVisualStyleBackColor = true;
            this.PerfExcelBtn.Click += new System.EventHandler(this.PerfExcelBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutBtn.Location = new System.Drawing.Point(717, 17);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(45, 23);
            this.AboutBtn.TabIndex = 9;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // ChartBtn
            // 
            this.ChartBtn.Location = new System.Drawing.Point(396, 17);
            this.ChartBtn.Name = "ChartBtn";
            this.ChartBtn.Size = new System.Drawing.Size(64, 23);
            this.ChartBtn.TabIndex = 8;
            this.ChartBtn.Text = "Chart";
            this.ChartBtn.UseVisualStyleBackColor = true;
            this.ChartBtn.Click += new System.EventHandler(this.ChartBtn_Click);
            // 
            // ExportNewCSVBtn
            // 
            this.ExportNewCSVBtn.Location = new System.Drawing.Point(319, 17);
            this.ExportNewCSVBtn.Name = "ExportNewCSVBtn";
            this.ExportNewCSVBtn.Size = new System.Drawing.Size(71, 23);
            this.ExportNewCSVBtn.TabIndex = 4;
            this.ExportNewCSVBtn.Text = "Export";
            this.ExportNewCSVBtn.UseVisualStyleBackColor = true;
            this.ExportNewCSVBtn.Click += new System.EventHandler(this.ExportNewCSVBtn_Click);
            // 
            // StartConversionBtn
            // 
            this.StartConversionBtn.Location = new System.Drawing.Point(213, 17);
            this.StartConversionBtn.Name = "StartConversionBtn";
            this.StartConversionBtn.Size = new System.Drawing.Size(100, 23);
            this.StartConversionBtn.TabIndex = 3;
            this.StartConversionBtn.Text = "Start Conversion";
            this.StartConversionBtn.UseVisualStyleBackColor = true;
            this.StartConversionBtn.Click += new System.EventHandler(this.StartConversionBtn_Click);
            // 
            // SelectColumnsBtn
            // 
            this.SelectColumnsBtn.Location = new System.Drawing.Point(119, 17);
            this.SelectColumnsBtn.Name = "SelectColumnsBtn";
            this.SelectColumnsBtn.Size = new System.Drawing.Size(88, 23);
            this.SelectColumnsBtn.TabIndex = 2;
            this.SelectColumnsBtn.Text = "Select Columns";
            this.SelectColumnsBtn.UseVisualStyleBackColor = true;
            this.SelectColumnsBtn.Click += new System.EventHandler(this.SelectColumnsBtn_Click);
            // 
            // ChooseSourceFileBtn
            // 
            this.ChooseSourceFileBtn.Location = new System.Drawing.Point(12, 17);
            this.ChooseSourceFileBtn.Name = "ChooseSourceFileBtn";
            this.ChooseSourceFileBtn.Size = new System.Drawing.Size(101, 23);
            this.ChooseSourceFileBtn.TabIndex = 1;
            this.ChooseSourceFileBtn.Text = "Choose Sourcefile";
            this.ChooseSourceFileBtn.UseVisualStyleBackColor = true;
            this.ChooseSourceFileBtn.Click += new System.EventHandler(this.ChooseSourceFileBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "csv|*.csv";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Log);
            this.splitContainer1.Size = new System.Drawing.Size(774, 408);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 3;
            // 
            // backgroundWorkerConversion
            // 
            this.backgroundWorkerConversion.WorkerReportsProgress = true;
            this.backgroundWorkerConversion.WorkerSupportsCancellation = true;
            this.backgroundWorkerConversion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConversion_DoWork);
            this.backgroundWorkerConversion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerConversion_ProgressChanged);
            this.backgroundWorkerConversion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConversion_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(790, 500);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Eng Stats Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Log;

        private System.Windows.Forms.Button ChooseSourceFileBtn;
        private System.Windows.Forms.Button SelectColumnsBtn;
        private System.Windows.Forms.Button StartConversionBtn;
        private System.Windows.Forms.Button ExportNewCSVBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button ChartBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button PerfExcelBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConversion;
        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.Button TTExcelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

