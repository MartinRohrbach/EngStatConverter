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
            this.ChartSelectionChLb = new System.Windows.Forms.CheckedListBox();
            this.StackedCb = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LineRb = new System.Windows.Forms.RadioButton();
            this.SplineRb = new System.Windows.Forms.RadioButton();
            this.BarRb = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateChartBtn
            // 
            this.CreateChartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateChartBtn.Location = new System.Drawing.Point(201, 376);
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
            this.CancelBtn.Location = new System.Drawing.Point(12, 376);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ChartSelectionChLb
            // 
            this.ChartSelectionChLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartSelectionChLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartSelectionChLb.CheckOnClick = true;
            this.ChartSelectionChLb.FormattingEnabled = true;
            this.ChartSelectionChLb.Location = new System.Drawing.Point(12, 15);
            this.ChartSelectionChLb.Name = "ChartSelectionChLb";
            this.ChartSelectionChLb.Size = new System.Drawing.Size(264, 272);
            this.ChartSelectionChLb.TabIndex = 3;
            // 
            // StackedCb
            // 
            this.StackedCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StackedCb.AutoSize = true;
            this.StackedCb.Location = new System.Drawing.Point(201, 301);
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
            this.panel1.Location = new System.Drawing.Point(12, 293);
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
            // ChartSelectionForm
            // 
            this.AcceptButton = this.CreateChartBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(288, 411);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StackedCb);
            this.Controls.Add(this.ChartSelectionChLb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CreateChartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "ChartSelectionForm";
            this.Text = "Select Colums for Chart";
            this.Load += new System.EventHandler(this.ChartSelectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateChartBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckedListBox ChartSelectionChLb;
        private System.Windows.Forms.CheckBox StackedCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton LineRb;
        private System.Windows.Forms.RadioButton SplineRb;
        private System.Windows.Forms.RadioButton BarRb;
    }
}