using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace Windows资源管理器
{
    public partial class frmCheckDriver : Form
    {
        public frmCheckDriver()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
            foreach (ManagementObject disk in searcher.Get())
            {
                comboBox1.Items.Add(disk["Name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo dinfo = new DriveInfo(comboBox1.Text);
            if (dinfo.IsReady)
                label2.Text = "该磁盘已经准备好";
            else
                label2.Text = "该磁盘未准备好";
        }
    }
}