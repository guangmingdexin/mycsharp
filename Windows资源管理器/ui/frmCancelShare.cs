using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows资源管理器
{
    public partial class frmCancelShare : Form
    {
        public frmCancelShare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.RedirectStandardError = true;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            myProcess.StandardInput.WriteLine("NET SHARE " + textBox1.Text + "$ /DEL");
            MessageBox.Show("执行成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}