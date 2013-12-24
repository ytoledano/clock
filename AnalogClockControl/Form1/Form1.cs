using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _testBtn_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            (new TestCycleForm(int.Parse(button.Name.Replace("_test", "").Replace("Btn", "")))).ShowDialog();
        }
    }
}
