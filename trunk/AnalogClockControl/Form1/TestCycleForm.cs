using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogClockControl;
using System.IO;

namespace Form1
{
    public partial class TestCycleForm : Form
    {

        public TestCycleForm()
        {
            InitializeComponent();
        }

        public TestCycleForm(int testNum)
            : this()
        {
            _testNum = testNum;
            Text = "שעון " + testNum;
            _testCount = _testNum == 1 ? 3 : 50;

        }

        protected override void OnLoad(EventArgs e)
        {
            _countLabel.Text = (_i + 1).ToString();
            AnalogClock clockControl = new AnalogClock(_testNum);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
        }

        private void OnTestComplete(int userInputSecs, double beepSecs)
        {
            LogResult(_i,userInputSecs, beepSecs);
            _i++;
            _countLabel.Text = (_i + 1).ToString();
            foreach (var c in _clockGroup.Controls)
            {
                ((AnalogClock)c).OnTestComplete -= OnTestComplete;

            }
            _clockGroup.Controls.Clear();
            if (_i >= _testCount)
            {
                MessageBox.Show("סיימת את שלב " + _testNum);
                Close();
                return;
            }
            AnalogClock clockControl = new AnalogClock(_testNum);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
            clockControl.Focus();
        }

        private void LogResult(int gameNum, int userInputSecs, double beepSecs)
        {
            FileInfo file = new FileInfo("output.csv");
            if (!file.Exists)
                File.WriteAllText(file.FullName,"Subject ID,Cycle Num,Test Num,User Secs, Beep Secs,Time\r\n");
            File.AppendAllText(file.FullName,
                string.Format("{0},{1},{2},{3},{4},{5}\r\n", Form1.Form._idText.Text, _testNum, gameNum + 1,
                    userInputSecs, beepSecs, DateTime.Now));
        }



        private int _i;
        private readonly int _testNum;
        int _testCount;
    }
}
