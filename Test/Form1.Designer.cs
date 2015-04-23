namespace Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.mennu1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_1 = new DevExpress.XtraNavBar.NavBarItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            resources.ApplyResources(this.navBarControl1, "navBarControl1");
            this.navBarControl1.ActiveGroup = this.mennu1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mennu1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_1});
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.CollapsedWidth = ((int)(resources.GetObject("resource.CollapsedWidth")));
            this.navBarControl1.OptionsNavPane.ExpandedWidth = ((int)(resources.GetObject("resource.ExpandedWidth")));
            // 
            // mennu1
            // 
            resources.ApplyResources(this.mennu1, "mennu1");
            this.mennu1.Expanded = true;
            this.mennu1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_1)});
            this.mennu1.Name = "mennu1";
            // 
            // btn_1
            // 
            resources.ApplyResources(this.btn_1, "btn_1");
            this.btn_1.Name = "btn_1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup mennu1;
        private DevExpress.XtraNavBar.NavBarItem btn_1;
        private System.Windows.Forms.Label label1;

    }
}

