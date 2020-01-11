namespace Windows资源管理器
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.显示磁盘容量ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.检查磁盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.更新文件名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改文件属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改文件目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.映射网络驱动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.格式化磁盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消磁盘共享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton清空回收站 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton搜索 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton转到 = new System.Windows.Forms.ToolStripButton();
            this.TreeViewFile = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListViewFile = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示磁盘容量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件夹ToolStripMenuItem,
            this.删除文件夹ToolStripMenuItem,
            this.toolStripSeparator3,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 删除文件夹ToolStripMenuItem
            // 
            this.删除文件夹ToolStripMenuItem.Name = "删除文件夹ToolStripMenuItem";
            this.删除文件夹ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除文件夹ToolStripMenuItem.Text = "删除文件夹";
            this.删除文件夹ToolStripMenuItem.Click += new System.EventHandler(this.删除文件夹ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平铺ToolStripMenuItem,
            this.图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.详细资料ToolStripMenuItem,
            this.toolStripSeparator2,
            this.显示磁盘容量ToolStripMenuItem1,
            this.检查磁盘ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 平铺ToolStripMenuItem
            // 
            this.平铺ToolStripMenuItem.Name = "平铺ToolStripMenuItem";
            this.平铺ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.平铺ToolStripMenuItem.Text = "平铺";
            this.平铺ToolStripMenuItem.Click += new System.EventHandler(this.平铺ToolStripMenuItem_Click);
            // 
            // 图标ToolStripMenuItem
            // 
            this.图标ToolStripMenuItem.Name = "图标ToolStripMenuItem";
            this.图标ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图标ToolStripMenuItem.Text = "图标";
            this.图标ToolStripMenuItem.Click += new System.EventHandler(this.图标ToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
            // 
            // 详细资料ToolStripMenuItem
            // 
            this.详细资料ToolStripMenuItem.Name = "详细资料ToolStripMenuItem";
            this.详细资料ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.详细资料ToolStripMenuItem.Text = "详细信息";
            this.详细资料ToolStripMenuItem.Click += new System.EventHandler(this.详细资料ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 显示磁盘容量ToolStripMenuItem1
            // 
            this.显示磁盘容量ToolStripMenuItem1.Name = "显示磁盘容量ToolStripMenuItem1";
            this.显示磁盘容量ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.显示磁盘容量ToolStripMenuItem1.Text = "显示磁盘容量";
            this.显示磁盘容量ToolStripMenuItem1.Click += new System.EventHandler(this.显示磁盘容量ToolStripMenuItem1_Click);
            // 
            // 检查磁盘ToolStripMenuItem
            // 
            this.检查磁盘ToolStripMenuItem.Name = "检查磁盘ToolStripMenuItem";
            this.检查磁盘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检查磁盘ToolStripMenuItem.Text = "检查磁盘";
            this.检查磁盘ToolStripMenuItem.Click += new System.EventHandler(this.检查磁盘ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制文件ToolStripMenuItem,
            this.批量复制ToolStripMenuItem,
            this.toolStripSeparator1,
            this.更新文件名称ToolStripMenuItem,
            this.修改文件属性ToolStripMenuItem,
            this.修改文件目录ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 复制文件ToolStripMenuItem
            // 
            this.复制文件ToolStripMenuItem.Name = "复制文件ToolStripMenuItem";
            this.复制文件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复制文件ToolStripMenuItem.Text = "复制文件";
            this.复制文件ToolStripMenuItem.Click += new System.EventHandler(this.复制文件ToolStripMenuItem_Click);
            // 
            // 批量复制ToolStripMenuItem
            // 
            this.批量复制ToolStripMenuItem.Name = "批量复制ToolStripMenuItem";
            this.批量复制ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.批量复制ToolStripMenuItem.Text = "批量复制";
            this.批量复制ToolStripMenuItem.Click += new System.EventHandler(this.批量复制ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 更新文件名称ToolStripMenuItem
            // 
            this.更新文件名称ToolStripMenuItem.Name = "更新文件名称ToolStripMenuItem";
            this.更新文件名称ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新文件名称ToolStripMenuItem.Text = "更新文件名称";
            this.更新文件名称ToolStripMenuItem.Click += new System.EventHandler(this.更新文件名称ToolStripMenuItem_Click);
            // 
            // 修改文件属性ToolStripMenuItem
            // 
            this.修改文件属性ToolStripMenuItem.Name = "修改文件属性ToolStripMenuItem";
            this.修改文件属性ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改文件属性ToolStripMenuItem.Text = "修改文件属性";
            this.修改文件属性ToolStripMenuItem.Click += new System.EventHandler(this.修改文件属性ToolStripMenuItem_Click);
            // 
            // 修改文件目录ToolStripMenuItem
            // 
            this.修改文件目录ToolStripMenuItem.Name = "修改文件目录ToolStripMenuItem";
            this.修改文件目录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改文件目录ToolStripMenuItem.Text = "修改文件目录";
            this.修改文件目录ToolStripMenuItem.Click += new System.EventHandler(this.修改文件目录ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.映射网络驱动ToolStripMenuItem,
            this.toolStripSeparator4,
            this.格式化磁盘ToolStripMenuItem,
            this.取消磁盘共享ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 映射网络驱动ToolStripMenuItem
            // 
            this.映射网络驱动ToolStripMenuItem.Name = "映射网络驱动ToolStripMenuItem";
            this.映射网络驱动ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.映射网络驱动ToolStripMenuItem.Text = "映射网络驱动器";
            this.映射网络驱动ToolStripMenuItem.Click += new System.EventHandler(this.映射网络驱动ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // 格式化磁盘ToolStripMenuItem
            // 
            this.格式化磁盘ToolStripMenuItem.Name = "格式化磁盘ToolStripMenuItem";
            this.格式化磁盘ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.格式化磁盘ToolStripMenuItem.Text = "格式化磁盘";
            this.格式化磁盘ToolStripMenuItem.Click += new System.EventHandler(this.格式化磁盘ToolStripMenuItem_Click);
            // 
            // 取消磁盘共享ToolStripMenuItem
            // 
            this.取消磁盘共享ToolStripMenuItem.Name = "取消磁盘共享ToolStripMenuItem";
            this.取消磁盘共享ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.取消磁盘共享ToolStripMenuItem.Text = "取消磁盘共享";
            this.取消磁盘共享ToolStripMenuItem.Click += new System.EventHandler(this.取消磁盘共享ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton清空回收站,
            this.toolStripButton搜索,
            this.toolStripComboBox1,
            this.toolStripButton转到});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(413, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton清空回收站
            // 
            this.toolStripButton清空回收站.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton清空回收站.Image")));
            this.toolStripButton清空回收站.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton清空回收站.Name = "toolStripButton清空回收站";
            this.toolStripButton清空回收站.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton清空回收站.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton清空回收站.Text = "清空回收站";
            this.toolStripButton清空回收站.Click += new System.EventHandler(this.toolStripButton清空回收站_Click);
            // 
            // toolStripButton搜索
            // 
            this.toolStripButton搜索.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton搜索.Image")));
            this.toolStripButton搜索.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton搜索.Name = "toolStripButton搜索";
            this.toolStripButton搜索.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton搜索.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton搜索.Text = "搜索";
            this.toolStripButton搜索.Click += new System.EventHandler(this.toolStripButton搜索_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripComboBox1.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButton转到
            // 
            this.toolStripButton转到.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton转到.Image")));
            this.toolStripButton转到.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton转到.Name = "toolStripButton转到";
            this.toolStripButton转到.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton转到.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton转到.Text = "转到";
            this.toolStripButton转到.Click += new System.EventHandler(this.toolStripButton转到_Click);
            // 
            // TreeViewFile
            // 
            this.TreeViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewFile.ImageIndex = 0;
            this.TreeViewFile.ImageList = this.imageList1;
            this.TreeViewFile.Location = new System.Drawing.Point(0, 0);
            this.TreeViewFile.Name = "TreeViewFile";
            this.TreeViewFile.SelectedImageIndex = 0;
            this.TreeViewFile.Size = new System.Drawing.Size(162, 326);
            this.TreeViewFile.TabIndex = 2;
            this.TreeViewFile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewFile_NodeMouseDoubleClick);
            this.TreeViewFile.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewFile_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "39.gif");
            this.imageList1.Images.SetKeyName(1, "25.gif");
            this.imageList1.Images.SetKeyName(2, "02.gif");
            this.imageList1.Images.SetKeyName(3, "19.gif");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeViewFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListViewFile);
            this.splitContainer1.Size = new System.Drawing.Size(413, 326);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 4;
            // 
            // ListViewFile
            // 
            this.ListViewFile.BackgroundImageTiled = true;
            this.ListViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewFile.LargeImageList = this.imageList1;
            this.ListViewFile.Location = new System.Drawing.Point(0, 0);
            this.ListViewFile.Name = "ListViewFile";
            this.ListViewFile.Size = new System.Drawing.Size(247, 326);
            this.ListViewFile.SmallImageList = this.imageList1;
            this.ListViewFile.TabIndex = 0;
            this.ListViewFile.UseCompatibleStateImageBehavior = false;
            this.ListViewFile.View = System.Windows.Forms.View.Tile;
            this.ListViewFile.DoubleClick += new System.EventHandler(this.ListViewFile_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示磁盘容量ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // 显示磁盘容量ToolStripMenuItem
            // 
            this.显示磁盘容量ToolStripMenuItem.Name = "显示磁盘容量ToolStripMenuItem";
            this.显示磁盘容量ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.显示磁盘容量ToolStripMenuItem.Text = "显示磁盘容量";
            this.显示磁盘容量ToolStripMenuItem.Click += new System.EventHandler(this.显示磁盘容量ToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(319, 381);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "显示时间";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "时间";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 397);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Windows资源管理器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton清空回收站;
        private System.Windows.Forms.ToolStripButton toolStripButton搜索;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.TreeView TreeViewFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView ListViewFile;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton转到;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 映射网络驱动ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 更新文件名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改文件属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改文件目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示磁盘容量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 显示磁盘容量ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 格式化磁盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查磁盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消磁盘共享ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

