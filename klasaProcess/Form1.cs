using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace klasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void btnStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "http://web2.ss-zcrnje-rovinj.skole.hr/";
            Process.Start(startInfo);
        }
    }
}
