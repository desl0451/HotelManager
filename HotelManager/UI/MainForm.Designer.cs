namespace HotelManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuHotel = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRoomTypeManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRoomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuestRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRoomStateQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecordInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tBiao = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQieHuanYongHu = new System.Windows.Forms.ToolStripButton();
            this.tsbSuoDingXiTong = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTuiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuHotel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHotel
            // 
            this.menuHotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.基础设置ToolStripMenuItem,
            this.业务管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮ToolStripMenuItem});
            this.menuHotel.Location = new System.Drawing.Point(0, 0);
            this.menuHotel.Name = "menuHotel";
            this.menuHotel.Size = new System.Drawing.Size(1072, 29);
            this.menuHotel.TabIndex = 2;
            this.menuHotel.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiTuiChu});
            this.系统ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.系统ToolStripMenuItem.Text = "系统设置";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRoomTypeManage,
            this.tsmRoomManage});
            this.基础设置ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // tsmRoomTypeManage
            // 
            this.tsmRoomTypeManage.Name = "tsmRoomTypeManage";
            this.tsmRoomTypeManage.Size = new System.Drawing.Size(176, 26);
            this.tsmRoomTypeManage.Text = "房间类型管理";
            this.tsmRoomTypeManage.Click += new System.EventHandler(this.tsmRoomTypeManage_Click);
            // 
            // tsmRoomManage
            // 
            this.tsmRoomManage.Name = "tsmRoomManage";
            this.tsmRoomManage.Size = new System.Drawing.Size(176, 26);
            this.tsmRoomManage.Text = "房间信息管理";
            this.tsmRoomManage.Click += new System.EventHandler(this.tsmRoomManage_Click);
            // 
            // 业务管理ToolStripMenuItem
            // 
            this.业务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGuestRecord,
            this.tsmRoomStateQuery,
            this.tsmRecordInfo});
            this.业务管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.业务管理ToolStripMenuItem.Name = "业务管理ToolStripMenuItem";
            this.业务管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.业务管理ToolStripMenuItem.Text = "业务管理";
            // 
            // tsmGuestRecord
            // 
            this.tsmGuestRecord.Name = "tsmGuestRecord";
            this.tsmGuestRecord.Size = new System.Drawing.Size(176, 26);
            this.tsmGuestRecord.Text = "入住登记";
            this.tsmGuestRecord.Click += new System.EventHandler(this.tsmGuestRecord_Click);
            // 
            // tsmRoomStateQuery
            // 
            this.tsmRoomStateQuery.Name = "tsmRoomStateQuery";
            this.tsmRoomStateQuery.Size = new System.Drawing.Size(176, 26);
            this.tsmRoomStateQuery.Text = "房间信息查看";
            this.tsmRoomStateQuery.Click += new System.EventHandler(this.tsmRoomStateQuery_Click);
            // 
            // tsmRecordInfo
            // 
            this.tsmRecordInfo.Name = "tsmRecordInfo";
            this.tsmRecordInfo.Size = new System.Drawing.Size(176, 26);
            this.tsmRecordInfo.Text = "顾客信息查询";
            this.tsmRecordInfo.Click += new System.EventHandler(this.tsmRecordInfo_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 帮ToolStripMenuItem
            // 
            this.帮ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.帮ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.帮ToolStripMenuItem.Name = "帮ToolStripMenuItem";
            this.帮ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.帮ToolStripMenuItem.Text = "帮助信息";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.aToolStripMenuItem.Text = "a";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.tsslTime,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "版本:V1.0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(256, 17);
            this.toolStripStatusLabel3.Text = "                     技术支持热线:0451-88888888";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = "  ";
            // 
            // tsslTime
            // 
            this.tsslTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslTime.Size = new System.Drawing.Size(131, 17);
            this.tsslTime.Text = "toolStripStatusLabel3";
            // 
            // tBiao
            // 
            this.tBiao.Enabled = true;
            this.tBiao.Interval = 1000;
            this.tBiao.Tick += new System.EventHandler(this.tBiao_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(225)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQieHuanYongHu,
            this.tsbSuoDingXiTong,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 44);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbQieHuanYongHu
            // 
            this.tsbQieHuanYongHu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tsbQieHuanYongHu.Image = ((System.Drawing.Image)(resources.GetObject("tsbQieHuanYongHu.Image")));
            this.tsbQieHuanYongHu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQieHuanYongHu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQieHuanYongHu.Name = "tsbQieHuanYongHu";
            this.tsbQieHuanYongHu.Size = new System.Drawing.Size(78, 41);
            this.tsbQieHuanYongHu.Text = "切换用户";
            this.tsbQieHuanYongHu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSuoDingXiTong
            // 
            this.tsbSuoDingXiTong.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tsbSuoDingXiTong.Image = ((System.Drawing.Image)(resources.GetObject("tsbSuoDingXiTong.Image")));
            this.tsbSuoDingXiTong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuoDingXiTong.Name = "tsbSuoDingXiTong";
            this.tsbSuoDingXiTong.Size = new System.Drawing.Size(78, 41);
            this.tsbSuoDingXiTong.Text = "锁定系统";
            this.tsbSuoDingXiTong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSuoDingXiTong.Click += new System.EventHandler(this.tsbSuoDingXiTong_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 41);
            this.toolStripButton3.Text = "客人预定";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(78, 41);
            this.toolStripButton4.Text = "课人登记";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiTuiChu
            // 
            this.tsmiTuiChu.Name = "tsmiTuiChu";
            this.tsmiTuiChu.Size = new System.Drawing.Size(152, 26);
            this.tsmiTuiChu.Text = "退出(&X)";
            this.tsmiTuiChu.Click += new System.EventHandler(this.tsmiTuiChu_Click);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 551);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuHotel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店信息管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuHotel.ResumeLayout(false);
            this.menuHotel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHotel;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRoomTypeManage;
        private System.Windows.Forms.ToolStripMenuItem tsmRoomManage;
        private System.Windows.Forms.ToolStripMenuItem 业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmGuestRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmRoomStateQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmRecordInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.Timer tBiao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQieHuanYongHu;
        private System.Windows.Forms.ToolStripButton tsbSuoDingXiTong;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuiChu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

