using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Form1;

namespace Clock
{
    public partial class EndOfCycleDialog : Form
    {
        private readonly int _testNum;

        public EndOfCycleDialog()
        {
            InitializeComponent();
        }

        public EndOfCycleDialog(int testNum) : this()
        {
            _testNum = testNum;
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int num;
            if (int.TryParse(text, out num) && num >= 1 && num <= 8)
            {
                TestCycleForm.LogResult(_testNum,-1,num,0,"",0,"",0,0);
                Close();
            }
            else
            {
                MessageBox.Show("נא הכנס/י מספר בין 1 ל-8");
            }
        }
    }
}
