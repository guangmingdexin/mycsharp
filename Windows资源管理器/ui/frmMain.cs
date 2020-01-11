using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace Windows资源管理器
{
    public partial class frmMain : Form
    {
        int size;

        public frmMain()
        {
            InitializeComponent();
            size = splitContainer1.Panel1.Width;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TreeNode CountNode = new TreeNode("我的电脑");//初始化TreeView控件添加总结点
            //TreeViewFile控价名
            //Nodes 获取分配给树视图控件的树节点集合。
            TreeViewFile.Nodes.Add(CountNode);
            ListViewShow(CountNode);	//初始化ListView控件
            toolStripComboBox1.Text = "当前路径：" + System.Environment.CurrentDirectory;
           
        }
        //
        private void ListViewShow(TreeNode NodeDir)//初始化ListView控件，把TreeView控件中的数据添加进来
        {
            ListViewFile.Clear();

            if (NodeDir.Parent == null)// 如果当前TreeView的父结点为空，就把我的电脑下的分区名称添加进来
            {
                foreach (string DrvName in Directory.GetLogicalDrives())//获得硬盘分区名
                {
                    ListViewItem ItemList = new ListViewItem(DrvName);
                    ListViewFile.Items.Add(ItemList);//添加进来
                }
            }
            else//如果当前TreeView的父结点不为空，把点击的结点，做为一个目录文件的总结点
            {
                foreach (string DirName in Directory.GetDirectories((string)NodeDir.Tag))//编历当前分区或文件夹所有目录
                {
                    ListViewItem ItemList = new ListViewItem(DirName);
                    ListViewFile.Items.Add(ItemList);
                }
                foreach (string FileName in Directory.GetFiles((string)NodeDir.Tag))//编历当前分区或文件夹所有目录的文件
                {
                    ListViewItem ItemList = new ListViewItem(FileName);
                    ListViewFile.Items.Add(ItemList);
                }
            }
        }

        private void ListViewShow(string DirFileName)//获取当有文件夹内的文件和目录
        {
            ListViewFile.Clear();
            foreach (string DirName in Directory.GetDirectories(DirFileName))
            {
                ListViewItem ItemList = new ListViewItem(DirName);
                ListViewFile.Items.Add(ItemList);
            }
            foreach (string FileName in Directory.GetFiles(DirFileName))
            {
                ListViewItem ItemList = new ListViewItem(FileName);
                ListViewFile.Items.Add(ItemList);
            }
        }

        private void TreeViewShow(TreeNode NodeDir)//初始化TreeView控件
        {
            if (NodeDir.Nodes.Count == 0)
            {
                if (NodeDir.Parent == null)//如果结点为空显示硬盘分区
                {
                    foreach (string DrvName in Directory.GetLogicalDrives())
                    {
                        TreeNode aNode = new TreeNode(DrvName);
                        aNode.Tag = DrvName;
                        NodeDir.Nodes.Add(aNode);
                    }
                }// end 
                else// 不为空，显示分区下文件夹
                {
                    foreach (string DirName in Directory.GetDirectories((string)NodeDir.Tag))
                    {
                        TreeNode aNode = new TreeNode(DirName);
                        aNode.Tag = DirName;
                        NodeDir.Nodes.Add(aNode);
                    }
                }
            }
        }

        //TreeView点击事件 获取文件夹
        private void TreeViewFile_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ListViewShow(e.Node);
            TreeViewShow(e.Node);
        }
        //TreeView双击事件 获取当有文件夹内的文件和目录
        private void ListViewFile_DoubleClick(object sender, EventArgs e)
        {
            foreach (int ListIndex in ListViewFile.SelectedIndices)
            {
                ListViewShow(ListViewFile.Items[ListIndex].Text);
            }	
        }

        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateFolder fcf = new frmCreateFolder();
            fcf.ShowDialog();
        }

        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteFolder fdf = new frmDeleteFolder();
            fdf.ShowDialog();
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewFile.View = View.Tile;
        }

        private void 图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewFile.View = View.LargeIcon;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewFile.View = View.List;
        }

        private void 详细资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewFile.View = View.Details;
        }

        private void toolStripButton搜索_Click(object sender, EventArgs e)
        {
            frmSearchFile fsf = new frmSearchFile();
            fsf.ShowDialog();
        }

        // 提示用户选择文件夹。 此类不能被继承。
        private void toolStripButton转到_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripComboBox1.Text = folderBrowserDialog1.SelectedPath;
                tempstr = folderBrowserDialog1.SelectedPath;
                thdAddFile = new Thread(new ThreadStart(SetAddFile));   //创建一个线程
                thdAddFile.Start(); //执行当前线程
            }
        }

        private void 复制文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopyFile fcf = new frmCopyFile();
            fcf.ShowDialog();
        }

        private void 批量复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopyAmount fca = new frmCopyAmount();
            fca.ShowDialog();
        }

        private void 映射网络驱动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNetDriver fnd = new frmNetDriver();
            fnd.ShowDialog();
        }

        public static string tempstr = "";
        string Tem_Dir = "";
        private System.Threading.Thread thdAddFile; //创建一个线程
        public static TreeNode TN_Docu = new TreeNode();//单个文件的节点

        public delegate void AddFile();//定义托管线程
        /// <summary>
        /// 设置托管线程
        /// </summary>
        public void SetAddFile()
        {
            this.Invoke(new AddFile(RunAddFile));//对指定的线程进行托管
        }

        /// <summary>
        /// 设置线程
        /// </summary>
        public void RunAddFile()
        {
            TreeNode TNode = new TreeNode();//实例化一个线程
            Files_Copy(TreeViewFile, tempstr, TNode, 0);
            Thread.Sleep(0);//持起主线程
            thdAddFile.Abort();//执行线程      
        }

        #region  返回上一级目录
        /// <summary>
        /// 返回上一级目录
        /// </summary>
        /// <param dir="string">目录</param>
        /// <returns>返回String对象</returns>
        public string UpAndDown_Dir(string dir)
        {
            string Change_dir = "";
            Change_dir = Directory.GetParent(dir).FullName;
            return Change_dir;
        }
        #endregion

        #region  显示文件夹下所有子文件夹及文件的名称
        /// <summary>
        /// 显示文件夹下所有子文件夹及文件的名称
        /// </summary>
        /// <param Sdir="string">文件夹的目录</param>
        /// <param TNode="TreeNode">节点</param>
        /// <param n="int">标识，判断当前是文件夹，还是文件</param>
        private void Files_Copy(TreeView TV, string Sdir, TreeNode TNode, int n)
        {
            DirectoryInfo dir = new DirectoryInfo(Sdir);
            try
            {
                if (!dir.Exists)//判断所指的文件或文件夹是否存在
                {
                    return;
                }
                DirectoryInfo dirD = dir as DirectoryInfo;//如果给定参数不是文件夹则退出
                if (dirD == null)//判断文件夹是否为空
                {
                    return;
                }
                else
                {
                    if (n == 0)
                    {
                        TNode = TV.Nodes.Add(dirD.Name);//添加文件夹的名称
                        TNode.Tag = 1;
                    }
                    else
                    {
                        TNode = TNode.Nodes.Add(dirD.Name);//添加文件夹里面各文件夹的名称
                        TNode.Tag = 1;
                    }
                }
                FileSystemInfo[] files = dirD.GetFileSystemInfos();//获取文件夹中所有文件和文件夹
                //对单个FileSystemInfo进行判断,如果是文件夹则进行递归操作
                foreach (FileSystemInfo FSys in files)
                {
                    FileInfo file = FSys as FileInfo;
                    if (file != null)//如果是文件的话，进行文件的复制操作
                    {
                        FileInfo SFInfo = new FileInfo(file.DirectoryName + "\\" + file.Name);//获取文件所在的原始路径
                        TNode.Nodes.Add(file.Name);//添加文件
                        TNode.Tag = 1;
                    }
                    else
                    {
                        string pp = FSys.Name;//获取当前搜索到的文件夹名称
                        Files_Copy(TV, Sdir + "\\" + FSys.ToString(), TNode, 1);//如果是文件夹，则进行递归调用
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion

        private void TreeViewFile_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
                Tem_Dir = "";
            else
                Tem_Dir = e.Node.Tag.ToString();
            if (Tem_Dir == "")
            {
                Tem_Dir = UpAndDown_Dir(tempstr) + "\\" + e.Node.FullPath;
                System.Diagnostics.Process.Start(@Tem_Dir);
            }
        }

        const int SHERB_NOCONFIRMATION = 0x000001;
        const int SHERB_NOPROGRESSUI = 0x000002;
        const int SHERB_NOSOUND = 0x000004;
        [DllImportAttribute("shell32.dll")]
        private static extern int SHEmptyRecycleBin(IntPtr handle, string root, int falgs);

        private void toolStripButton清空回收站_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否要清空回收站", "提示", MessageBoxButtons.YesNo))
            {
                SHEmptyRecycleBin(this.Handle, "", SHERB_NOCONFIRMATION + SHERB_NOPROGRESSUI + SHERB_NOSOUND);
            }
        }

        private void 更新文件名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenameFile frf = new frmRenameFile();
            frf.ShowDialog();
        }

        private void 修改文件属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateFileAttribute fufa = new frmUpdateFileAttribute();
            fufa.ShowDialog();
        }

        private void 修改文件目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateFileDir fufd = new frmUpdateFileDir();
            fufd.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 显示磁盘容量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverStorage fds = new frmDriverStorage();
            fds.ShowDialog();
        }

        private void 显示磁盘容量ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDriverStorage fds = new frmDriverStorage();
            fds.ShowDialog();
        }

        private void 格式化磁盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormatDriver ffd = new frmFormatDriver();
            ffd.ShowDialog();
        }

        private void 检查磁盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckDriver fcd = new frmCheckDriver();
            fcd.ShowDialog();
        }

        private void 取消磁盘共享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelShare fcs = new frmCancelShare();
            fcs.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                MainInterface mainInterface = new MainImpl();                   
                toolStripStatusLabel1.Text = mainInterface.showDate();
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
        }

    }
}