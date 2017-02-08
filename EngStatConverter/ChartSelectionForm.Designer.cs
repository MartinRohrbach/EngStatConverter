namespace EngStatConverter
{
    partial class ChartSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartSelectionForm));
            this.CreateChartBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StackedCb = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LineRb = new System.Windows.Forms.RadioButton();
            this.SplineRb = new System.Windows.Forms.RadioButton();
            this.BarRb = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartSelectionChLbAxis1 = new System.Windows.Forms.CheckedListBox();
            this.ChartSelectionChLbAxis2 = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClearSelectionBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateChartBtn
            // 
            this.CreateChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateChartBtn.Location = new System.Drawing.Point(470, 475);
            this.CreateChartBtn.Name = "CreateChartBtn";
            this.CreateChartBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateChartBtn.TabIndex = 0;
            this.CreateChartBtn.Text = "Create Chart";
            this.CreateChartBtn.UseVisualStyleBackColor = true;
            this.CreateChartBtn.Click += new System.EventHandler(this.CreateChartBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(12, 475);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // StackedCb
            // 
            this.StackedCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StackedCb.AutoSize = true;
            this.StackedCb.Location = new System.Drawing.Point(470, 400);
            this.StackedCb.Name = "StackedCb";
            this.StackedCb.Size = new System.Drawing.Size(64, 17);
            this.StackedCb.TabIndex = 5;
            this.StackedCb.Text = "stacked";
            this.StackedCb.UseVisualStyleBackColor = true;
            this.StackedCb.CheckStateChanged += new System.EventHandler(this.ChartTypeChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.LineRb);
            this.panel1.Controls.Add(this.SplineRb);
            this.panel1.Controls.Add(this.BarRb);
            this.panel1.Location = new System.Drawing.Point(12, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 70);
            this.panel1.TabIndex = 8;
            // 
            // LineRb
            // 
            this.LineRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LineRb.AutoSize = true;
            this.LineRb.Location = new System.Drawing.Point(5, 5);
            this.LineRb.Name = "LineRb";
            this.LineRb.Size = new System.Drawing.Size(45, 17);
            this.LineRb.TabIndex = 10;
            this.LineRb.Text = "Line";
            this.LineRb.UseVisualStyleBackColor = true;
            this.LineRb.CheckedChanged += new System.EventHandler(this.ChartTypeChange);
            // 
            // SplineRb
            // 
            this.SplineRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SplineRb.AutoSize = true;
            this.SplineRb.Location = new System.Drawing.Point(5, 51);
            this.SplineRb.Name = "SplineRb";
            this.SplineRb.Size = new System.Drawing.Size(54, 17);
            this.SplineRb.TabIndex = 9;
            this.SplineRb.Text = "Spline";
            this.SplineRb.UseVisualStyleBackColor = true;
            this.SplineRb.CheckedChanged += new System.EventHandler(this.ChartTypeChange);
            // 
            // BarRb
            // 
            this.BarRb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BarRb.AutoSize = true;
            this.BarRb.Location = new System.Drawing.Point(5, 28);
            this.BarRb.Name = "BarRb";
            this.BarRb.Size = new System.Drawing.Size(41, 17);
            this.BarRb.TabIndex = 8;
            this.BarRb.Text = "Bar";
            this.BarRb.UseVisualStyleBackColor = true;
            this.BarRb.CheckedChanged += new System.EventHandler(this.ChartTypeChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChartSelectionChLbAxis1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChartSelectionChLbAxis2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 374);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Axis 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Axis 1";
            // 
            // ChartSelectionChLbAxis1
            // 
            this.ChartSelectionChLbAxis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartSelectionChLbAxis1.CheckOnClick = true;
            this.ChartSelectionChLbAxis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartSelectionChLbAxis1.FormattingEnabled = true;
            this.ChartSelectionChLbAxis1.Location = new System.Drawing.Point(3, 18);
            this.ChartSelectionChLbAxis1.Name = "ChartSelectionChLbAxis1";
            this.ChartSelectionChLbAxis1.Size = new System.Drawing.Size(255, 353);
            this.ChartSelectionChLbAxis1.TabIndex = 13;
            this.ChartSelectionChLbAxis1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChartSelectionChLbAxis1_ItemCheck);
            // 
            // ChartSelectionChLbAxis2
            // 
            this.ChartSelectionChLbAxis2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartSelectionChLbAxis2.CheckOnClick = true;
            this.ChartSelectionChLbAxis2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartSelectionChLbAxis2.FormattingEnabled = true;
            this.ChartSelectionChLbAxis2.Location = new System.Drawing.Point(274, 18);
            this.ChartSelectionChLbAxis2.Name = "ChartSelectionChLbAxis2";
            this.ChartSelectionChLbAxis2.Size = new System.Drawing.Size(256, 353);
            this.ChartSelectionChLbAxis2.TabIndex = 11;
            this.ChartSelectionChLbAxis2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChartSelectionChLbAxis2_ItemCheck);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(264, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 9);
            this.panel4.TabIndex = 6;
            // 
            // ClearSelectionBtn
            // 
            this.ClearSelectionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearSelectionBtn.Location = new System.Drawing.Point(230, 390);
            this.ClearSelectionBtn.Name = "ClearSelectionBtn";
            this.ClearSelectionBtn.Size = new System.Drawing.Size(97, 23);
            this.ClearSelectionBtn.TabIndex = 14;
            this.ClearSelectionBtn.Text = "Clear Selection";
            this.ClearSelectionBtn.UseVisualStyleBackColor = true;
            this.ClearSelectionBtn.Click += new System.EventHandler(this.ClearSelectionBtn_Click);
            // 
            // ChartSelectionForm
            // 
            this.AcceptButton = this.CreateChartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(557, 510);
            this.ControlBox = false;
            this.Controls.Add(this.ClearSelectionBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StackedCb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateChartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "ChartSelectionForm";
            this.Text = "Select Colums for Chart";
            this.Load += new System.EventHandler(this.ChartSelectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateChartBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox StackedCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton LineRb;
        private System.Windows.Forms.RadioButton SplineRb;
        private System.Windows.Forms.RadioButton BarRb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox ChartSelectionChLbAxis2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ChartSelectionChLbAxis1;
        private System.Windows.Forms.Button ClearSelectionBtn;
        private System.Windows.Forms.Label label2;
    }
}