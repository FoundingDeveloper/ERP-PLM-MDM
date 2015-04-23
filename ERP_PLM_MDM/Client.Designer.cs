namespace ERP_PLM_MDM
{
    partial class Client
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
            this.Menu_strip = new System.Windows.Forms.MenuStrip();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status_Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_loginname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_TimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel_Workplace = new BSE.Windows.Forms.Panel();
            this.panel_menu = new BSE.Windows.Forms.Panel();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.Menu_strip.SuspendLayout();
            this.Status_Strip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_strip
            // 
            this.Menu_strip.BackColor = System.Drawing.Color.LightBlue;
            this.Menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.个人信息管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.Menu_strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_strip.Name = "Menu_strip";
            this.Menu_strip.Size = new System.Drawing.Size(922, 25);
            this.Menu_strip.TabIndex = 0;
            this.Menu_strip.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改个人信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.个人信息管理ToolStripMenuItem.Text = "个人信息管理";
            this.个人信息管理ToolStripMenuItem.Click += new System.EventHandler(this.个人信息管理ToolStripMenuItem_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // Status_Strip
            // 
            this.Status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_loginname,
            this.toolStripStatusLabel_TimeNow});
            this.Status_Strip.Location = new System.Drawing.Point(0, 435);
            this.Status_Strip.Name = "Status_Strip";
            this.Status_Strip.Size = new System.Drawing.Size(922, 22);
            this.Status_Strip.TabIndex = 1;
            this.Status_Strip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_loginname
            // 
            this.toolStripStatusLabel_loginname.Name = "toolStripStatusLabel_loginname";
            this.toolStripStatusLabel_loginname.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel_loginname.Text = "登录人：           ";
            // 
            // toolStripStatusLabel_TimeNow
            // 
            this.toolStripStatusLabel_TimeNow.Name = "toolStripStatusLabel_TimeNow";
            this.toolStripStatusLabel_TimeNow.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel_TimeNow.Text = "当前时间：";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel_Workplace);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel_menu);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(922, 385);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 25);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(922, 410);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel_Workplace
            // 
            this.panel_Workplace.BackColor = System.Drawing.Color.Transparent;
            this.panel_Workplace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_Workplace.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.panel_Workplace.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Workplace.CloseIconForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Workplace.CollapsedCaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Workplace.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_Workplace.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.panel_Workplace.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_Workplace.ColorContentPanelGradientBegin = System.Drawing.Color.Empty;
            this.panel_Workplace.ColorContentPanelGradientEnd = System.Drawing.Color.Empty;
            this.panel_Workplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Workplace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Workplace.Image = null;
            this.panel_Workplace.InnerBorderColor = System.Drawing.Color.White;
            this.panel_Workplace.Location = new System.Drawing.Point(189, 0);
            this.panel_Workplace.Name = "panel_Workplace";
            this.panel_Workplace.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.panel_Workplace.ShowExpandIcon = true;
            this.panel_Workplace.ShowTransparentBackground = false;
            this.panel_Workplace.Size = new System.Drawing.Size(733, 385);
            this.panel_Workplace.TabIndex = 1;
            this.panel_Workplace.Text = "工作区";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_menu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_menu.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.panel_menu.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_menu.CloseIconForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_menu.CollapsedCaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_menu.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel_menu.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.panel_menu.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_menu.ColorContentPanelGradientBegin = System.Drawing.Color.Empty;
            this.panel_menu.ColorContentPanelGradientEnd = System.Drawing.Color.Empty;
            this.panel_menu.Controls.Add(this.navBarControl1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_menu.Image = null;
            this.panel_menu.InnerBorderColor = System.Drawing.Color.White;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.panel_menu.ShowExpandIcon = true;
            this.panel_menu.ShowTransparentBackground = false;
            this.panel_menu.Size = new System.Drawing.Size(189, 385);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Text = "菜单";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Location = new System.Drawing.Point(1, 26);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 187;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl1.Size = new System.Drawing.Size(187, 358);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2010 Blue");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "navBarGroup2";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "navBarGroup3";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 457);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Status_Strip);
            this.Controls.Add(this.Menu_strip);
            this.MainMenuStrip = this.Menu_strip;
            this.Name = "Client";
            this.Text = "企业信息系统";
            this.Menu_strip.ResumeLayout(false);
            this.Menu_strip.PerformLayout();
            this.Status_Strip.ResumeLayout(false);
            this.Status_Strip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_strip;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Status_Strip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_loginname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_TimeNow;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private BSE.Windows.Forms.Panel panel_Workplace;
        private BSE.Windows.Forms.Panel panel_menu;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
    }
}

