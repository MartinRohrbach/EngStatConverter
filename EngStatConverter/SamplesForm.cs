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
    public partial class SamplesForm : Form
    {
        public SamplesForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClipboardBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(SampleTb.Text);
            MessageBox.Show("Sample copied to Clipboard");
        }
    }
}
