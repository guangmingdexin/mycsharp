﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Windows资源管理器
{
    public partial class frmCreateFolder : Form
    {
        public frmCreateFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("是否要创建文件夹"+textBox1.Text.ToString(), "提示", MessageBoxButtons.YesNo))
            {

                Directory.CreateDirectory(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}