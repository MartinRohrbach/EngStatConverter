namespace EngStatConverter
{
    partial class ChartForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetStartTimeCMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SetEndTimeCMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetTimeFilterCMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LeftAxisMaxTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RightAxisMaxTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.ChartContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.ChartContextMenu;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(680, 414);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart2";
            // 
            // ChartContextMenu
            // 
            this.ChartContextMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.ChartContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetStartTimeCMI,
            this.SetEndTimeCMI,
            this.ResetTimeFilterCMI});
            this.ChartContextMenu.Name = "ChartContextMenu";
            this.ChartContextMenu.Size = new System.Drawing.Size(162, 70);
            this.ChartContextMenu.Text = "Set X Axis Min";
            // 
            // SetStartTimeCMI
            // 
            this.SetStartTimeCMI.Name = "SetStartTimeCMI";
            this.SetStartTimeCMI.Size = new System.Drawing.Size(161, 22);
            this.SetStartTimeCMI.Text = "Set StartTime";
            this.SetStartTimeCMI.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // SetEndTimeCMI
            // 
            this.SetEndTimeCMI.Name = "SetEndTimeCMI";
            this.SetEndTimeCMI.Size = new System.Drawing.Size(161, 22);
            this.SetEndTimeCMI.Text = "Set End Time";
            this.SetEndTimeCMI.Click += new System.EventHandler(this.SetEndTimeCMI_Click);
            // 
            // ResetTimeFilterCMI
            // 
            this.ResetTimeFilterCMI.Name = "ResetTimeFilterCMI";
            this.ResetTimeFilterCMI.Size = new System.Drawing.Size(161, 22);
            this.ResetTimeFilterCMI.Text = "Reset Time Filter";
            this.ResetTimeFilterCMI.Click += new System.EventHandler(this.ResetTimeFilterCMI_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelBtn.Location = new System.Drawing.Point(12, 456);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveImageBtn.Location = new System.Drawing.Point(617, 456);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveImageBtn.TabIndex = 2;
            this.SaveImageBtn.Text = "Save Image";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.Filter = "png|*.png";
            this.saveFileDialog.Title = "Export Image Name";
            // 
            // LeftAxisMaxTb
            // 
            this.LeftAxisMaxTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftAxisMaxTb.Location = new System.Drawing.Point(234, 456);
            this.LeftAxisMaxTb.MaxLength = 7;
            this.LeftAxisMaxTb.Name = "LeftAxisMaxTb";
            this.LeftAxisMaxTb.Size = new System.Drawing.Size(54, 20);
            this.LeftAxisMaxTb.TabIndex = 3;
            this.LeftAxisMaxTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AxisMaxTb_Keypress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Left Axis Maximum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyBtn.Location = new System.Drawing.Point(460, 456);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(42, 23);
            this.ApplyBtn.TabIndex = 5;
            this.ApplyBtn.Text = "apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use Right Click to specify Start- and End Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Right Axis Maximum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightAxisMaxTb
            // 
            this.RightAxisMaxTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RightAxisMaxTb.Location = new System.Drawing.Point(399, 456);
            this.RightAxisMaxTb.MaxLength = 7;
            this.RightAxisMaxTb.Name = "RightAxisMaxTb";
            this.RightAxisMaxTb.Size = new System.Drawing.Size(54, 20);
            this.RightAxisMaxTb.TabIndex = 7;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RightAxisMaxTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeftAxisMaxTb);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.chart);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ChartContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox LeftAxisMaxTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.ContextMenuStrip ChartContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SetStartTimeCMI;
        private System.Windows.Forms.ToolStripMenuItem SetEndTimeCMI;
        private System.Windows.Forms.ToolStripMenuItem ResetTimeFilterCMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RightAxisMaxTb;
    }
}