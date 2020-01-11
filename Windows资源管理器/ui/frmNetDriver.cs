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
    public partial class frmNetDriver : Form
    {
        public frmNetDriver()
        {
            InitializeComponent();
        }

        private string[] DirName()
        {
            NetDriverInterface driverInterface = new NetDriverImpl();

            return driverInterface.dirName();
        }

        private void frmNetDriver_Load(object sender, EventArgs e)
        {
           this.comboBox2.DataSource = Environment.GetLogicalDrives();
           this.comboBox1.DataSource = DirName();
        }

        private bool ConDir(string Name, string Path)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = @"cmd.exe";
            psi.Arguments = @"/c delete use " + Name + " " + Path + "";
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            System.Diagnostics.Process.Start(psi);
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConDir(this.comboBox1.Text, this.textBox1.Text))
            {
                MessageBox.Show("已映射成功！！！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}