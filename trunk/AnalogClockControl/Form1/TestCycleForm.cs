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
            _testCount = _testNum == 1 ? 25 : 50;

        }

        protected override void OnLoad(EventArgs e)
        {
            _countLabel.Text = (_i + 1).ToString();
            AnalogClock clockControl = new AnalogClock(_testNum, true);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
        }

        private void OnTestComplete(int userInputSecs, double beepSecs, string sideClicked, double secsClicked, string inhibition, int soundHz)
        {
            if (userInputSecs != -1)
            {
                LogResult(_i, userInputSecs, beepSecs, sideClicked, secsClicked, inhibition, soundHz);
                _i++;
            }
            _countLabel.Text = (_i + 1).ToString();
            foreach (var c in _clockGroup.Controls)
                ((AnalogClock) c).OnTestComplete -= OnTestComplete;
            _clockGroup.Controls.Clear();
            if (_i >= _testCount)
            {
                MessageBox.Show("סיימת את שלב " + _testNum);
                Close();
                return;
            }
            AnalogClock clockControl = new AnalogClock(_testNum, false);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
            clockControl.Focus();
        }

        private void LogResult(int gameNum, int userInputSecs, double beepSecs, string sideClicked, double secsClicked, string inhibition, int soundHz)
        {
            FileInfo file = new FileInfo("output.csv");
            if (!file.Exists)
                File.WriteAllText(file.FullName, "Subject ID,Time,Cycle Num,Test Num,User Secs,Beep Secs,Side Clicked,Inhibition,Clicked Secs,Sound HZ\r\n");
            File.AppendAllText(file.FullName,
                string.Format("{0},{1},{2},{3},{4},{5:n2},\"{6}\",\"{7}\",{8:n2},{9}\r\n", Form1.Form._idText.Text, DateTime.Now, _testNum, gameNum + 1,
                    userInputSecs, beepSecs, sideClicked, inhibition, secsClicked, soundHz));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            foreach(Control control in _clockGroup.Controls)
                control.Dispose();
        }

        private int _i;
        private readonly int _testNum;
        readonly int _testCount;
    }
}
