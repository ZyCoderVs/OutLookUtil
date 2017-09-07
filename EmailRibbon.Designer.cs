namespace OutlookAddIn1
{
    partial class EmailRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EmailRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnEmail = this.Factory.CreateRibbonButton();
            this.btnMetting = this.Factory.CreateRibbonButton();
            this.btnBrowser = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "数智源";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnEmail);
            this.group1.Items.Add(this.btnMetting);
            this.group1.Items.Add(this.btnBrowser);
            this.group1.Name = "group1";
            // 
            // btnEmail
            // 
            this.btnEmail.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnEmail.Image = global::OutlookAddIn1.Properties.Resources._24772;
            this.btnEmail.Label = "普通会议";
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.ShowImage = true;
            this.btnEmail.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnEmail_Click);
            // 
            // btnMetting
            // 
            this.btnMetting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnMetting.Image = global::OutlookAddIn1.Properties.Resources.QQ截图20170907123018;
            this.btnMetting.Label = "Metting会议";
            this.btnMetting.Name = "btnMetting";
            this.btnMetting.ShowImage = true;
            this.btnMetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMetting_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnBrowser.Image = global::OutlookAddIn1.Properties.Resources.QQ截图20170907123018;
            this.btnBrowser.Label = "打开浏览器";
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.ShowImage = true;
            this.btnBrowser.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnBrowser_Click);
            // 
            // EmailRibbon
            // 
            this.Name = "EmailRibbon";
            this.RibbonType = resources.GetString("$this.RibbonType");
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EmailRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnEmail;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMetting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnBrowser;
    }

    partial class ThisRibbonCollection
    {
        internal EmailRibbon EmailRibbon
        {
            get { return this.GetRibbon<EmailRibbon>(); }
        }
    }
}
