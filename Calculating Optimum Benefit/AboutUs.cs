using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatingOptimumBenefit
{
    public partial class AboutUs : Form
    {
        public MainForm MainForm1;
        public AboutUs()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm1.Enabled = true;
        }

    }
}
