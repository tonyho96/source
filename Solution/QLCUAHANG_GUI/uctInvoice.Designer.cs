namespace QLCUAHANG_GUI
{
    partial class uctInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctInvoice));
            this.tabControlBill = new System.Windows.Forms.TabControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnSaleManager = new DevExpress.XtraNavBar.NavBarItem();
            this.btnPurchaseManager = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.btnTotalDebtÒCutomer = new DevExpress.XtraNavBar.NavBarItem();
            this.btnTotalDebtOfAgency = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBill
            // 
            this.tabControlBill.Location = new System.Drawing.Point(193, 0);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(1300, 543);
            this.tabControlBill.TabIndex = 1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnSaleManager,
            this.btnPurchaseManager,
            this.btnTotalDebtÒCutomer,
            this.btnTotalDebtOfAgency,
            this.navBarItem1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 195;
            this.navBarControl1.Size = new System.Drawing.Size(195, 543);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Invoice Management";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSaleManager),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPurchaseManager),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnSaleManager
            // 
            this.btnSaleManager.Caption = "Sales / Export";
            this.btnSaleManager.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSaleManager.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaleManager.ImageOptions.LargeImage")));
            this.btnSaleManager.ImageOptions.LargeImageIndex = 1;
            this.btnSaleManager.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSaleManager.ImageOptions.SmallImage")));
            this.btnSaleManager.Name = "btnSaleManager";
            this.btnSaleManager.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSaleManager_LinkClicked);
            // 
            // btnPurchaseManager
            // 
            this.btnPurchaseManager.Caption = "Import";
            this.btnPurchaseManager.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPurchaseManager.ImageOptions.SmallImage")));
            this.btnPurchaseManager.Name = "btnPurchaseManager";
            this.btnPurchaseManager.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPurchaseManager_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Services";
            this.navBarItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem1.ImageOptions.SvgImage")));
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // uctInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.tabControlBill);
            this.Name = "uctInvoice";
            this.Size = new System.Drawing.Size(1301, 543);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlBill;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnSaleManager;
        private DevExpress.XtraNavBar.NavBarItem btnPurchaseManager;
        private DevExpress.XtraNavBar.NavBarItem btnTotalDebtÒCutomer;
        private DevExpress.XtraNavBar.NavBarItem btnTotalDebtOfAgency;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
    }
}
