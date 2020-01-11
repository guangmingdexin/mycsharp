using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Windows资源管理器.Factory;

namespace Windows资源管理器
{
    public partial class frmCopyAmount : Form
    {
        public frmCopyAmount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            // 工厂模式
            CopyAmountInterface copyAmount = FactoryCopyAmountTool.GetCopyAmountTool();
            FileInfo[] f = copyAmount.fileInfos(textBox1.Text);
            for (int i = 0; i < f.Length; i++)
            {
                listBox1.Items.Add(f[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (object o in listBox1.SelectedItems)
            {
                File.Copy(textBox1.Text + "\\" + o.ToString(), textBox2.Text + "\\" + o.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}