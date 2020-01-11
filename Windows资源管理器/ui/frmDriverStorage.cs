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
    public partial class frmDriverStorage : Form
    {
        DriverStorage driverStorage = new DriverStorage();
        public frmDriverStorage()
        {
            InitializeComponent();
        }

        // 初始化加载一次
        private void Form1_Load(object sender, EventArgs e)
        {

            ManagementObjectSearcher searcher = driverStorage.searcher();

            foreach (ManagementObject disk in searcher.Get())
            {
                //向下拉列表中添加元素
                comboBox1.Items.Add(disk["Name"].ToString());
                // 输出c d f
                //Console.WriteLine(disk["Name"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = comboBox1.Text;
           
            float[] list = driverStorage.showDriverStorage(str);

            float tsize = list[0];
            float fsize = list[1];
            float totalFreeSpace = list[2];
            float totalSize = list[3];

            Graphics graphics = this.CreateGraphics();
            //Clear 清除整个绘图面并以指定背景色填充。
            graphics.Clear(Color.White);

            //Pen定义用于绘制直线和曲线的对象, Color指示Pen的颜色
            Pen pen1 = new Pen(Color.Red);

            //Brush定义用于填充图形形状
            Brush brush1 = new SolidBrush(Color.WhiteSmoke);
            Brush brush2 = new SolidBrush(Color.LimeGreen);
            Brush brush3 = new SolidBrush(Color.RoyalBlue);
            Font font1 = new Font("Courier New", 16, FontStyle.Bold);
            Font font2 = new Font("宋体", 9);
            graphics.DrawString("磁盘容量分析", font1, brush2, new Point(60, 50));
            float angle1 = Convert.ToSingle((360 * (Convert.ToSingle(fsize / 100000000000) / Convert.ToSingle(tsize / 100000000000))));
            float angle2 = Convert.ToSingle((360 * (Convert.ToSingle((tsize - fsize) / 100000000000) / Convert.ToSingle(tsize / 100000000000))));
            graphics.FillPie(brush2, 60, 80, 150, 150, 0, angle1);
            graphics.FillPie(brush3, 60, 80, 150, 150, angle1, angle2);
            graphics.DrawRectangle(pen1, 30, 235, 200, 50);
            graphics.FillRectangle(brush2, 35, 245, 20, 10);
            graphics.DrawString("磁盘剩余容量:" + totalFreeSpace / 1000 + "KB", font2, brush2, 55, 245);
            graphics.FillRectangle(brush3, 35, 265, 20, 10);
            graphics.DrawString("磁盘已用容量:" + (totalSize - totalFreeSpace) / 1000 + "KB", font2, brush3, 55, 265);
                   
        }


    }
}