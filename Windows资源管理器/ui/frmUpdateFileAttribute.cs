using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Windows资源管理器
{
    public partial class frmUpdateFileAttribute : Form
    {
        public frmUpdateFileAttribute()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo f = new System.IO.FileInfo(textBox1.Text);
            if(checkBox1.Checked == true)
            {
                f.Attributes = System.IO.FileAttributes.ReadOnly;
            }
            if (checkBox2.Checked == true)
            {
                f.Attributes = System.IO.FileAttributes.System;
            }
            if (checkBox3.Checked == true)
            {
                f.Attributes = System.IO.FileAttributes.Archive;
            }
            if (checkBox4.Checked == true)
            {
                f.Attributes = System.IO.FileAttributes.Hidden;
            }
        }
    }
}