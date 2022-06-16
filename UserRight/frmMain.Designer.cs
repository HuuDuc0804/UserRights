namespace UserRight
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m010101 = new DevExpress.XtraBars.BarButtonItem();
            this.m010102 = new DevExpress.XtraBars.BarButtonItem();
            this.m010103 = new DevExpress.XtraBars.BarButtonItem();
            this.m010201 = new DevExpress.XtraBars.BarButtonItem();
            this.m010202 = new DevExpress.XtraBars.BarButtonItem();
            this.m010203 = new DevExpress.XtraBars.BarButtonItem();
            this.m010301 = new DevExpress.XtraBars.BarButtonItem();
            this.m010302 = new DevExpress.XtraBars.BarButtonItem();
            this.m010303 = new DevExpress.XtraBars.BarButtonItem();
            this.m010304 = new DevExpress.XtraBars.BarButtonItem();
            this.m01 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.m0101 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0102 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0103 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.m010101,
            this.m010102,
            this.m010103,
            this.m010201,
            this.m010202,
            this.m010203,
            this.m010301,
            this.m010302,
            this.m010303,
            this.m010304});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.m01});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(884, 158);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // m010101
            // 
            this.m010101.Caption = "Exit";
            this.m010101.Id = 1;
            this.m010101.Name = "m010101";
            // 
            // m010102
            // 
            this.m010102.Caption = "Log out";
            this.m010102.Id = 2;
            this.m010102.Name = "m010102";
            // 
            // m010103
            // 
            this.m010103.Caption = "Lock";
            this.m010103.Id = 3;
            this.m010103.Name = "m010103";
            // 
            // m010201
            // 
            this.m010201.Caption = "Permission";
            this.m010201.Id = 4;
            this.m010201.Name = "m010201";
            this.m010201.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m010201_ItemClick);
            // 
            // m010202
            // 
            this.m010202.Caption = "Change pass";
            this.m010202.Id = 5;
            this.m010202.Name = "m010202";
            // 
            // m010203
            // 
            this.m010203.Caption = "History login";
            this.m010203.Id = 6;
            this.m010203.Name = "m010203";
            // 
            // m010301
            // 
            this.m010301.Caption = "Warehouse";
            this.m010301.Id = 7;
            this.m010301.Name = "m010301";
            // 
            // m010302
            // 
            this.m010302.Caption = "Product";
            this.m010302.Id = 8;
            this.m010302.Name = "m010302";
            // 
            // m010303
            // 
            this.m010303.Caption = "Customers";
            this.m010303.Id = 9;
            this.m010303.Name = "m010303";
            // 
            // m010304
            // 
            this.m010304.Caption = "Supplier";
            this.m010304.Id = 10;
            this.m010304.Name = "m010304";
            // 
            // m01
            // 
            this.m01.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.m0101,
            this.m0102,
            this.m0103});
            this.m01.Name = "m01";
            this.m01.Text = "Manager";
            // 
            // m0101
            // 
            this.m0101.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.m0101.ItemLinks.Add(this.m010101);
            this.m0101.ItemLinks.Add(this.m010102);
            this.m0101.ItemLinks.Add(this.m010103);
            this.m0101.Name = "m0101";
            this.m0101.Text = "System";
            // 
            // m0102
            // 
            this.m0102.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.m0102.ItemLinks.Add(this.m010201);
            this.m0102.ItemLinks.Add(this.m010202);
            this.m0102.ItemLinks.Add(this.m010203);
            this.m0102.Name = "m0102";
            this.m0102.Text = "User";
            // 
            // m0103
            // 
            this.m0103.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.m0103.ItemLinks.Add(this.m010301);
            this.m0103.ItemLinks.Add(this.m010302);
            this.m0103.ItemLinks.Add(this.m010303);
            this.m0103.ItemLinks.Add(this.m010304);
            this.m0103.Name = "m0103";
            this.m0103.Text = "Category";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage m01;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0101;
        private DevExpress.XtraBars.BarButtonItem m010101;
        private DevExpress.XtraBars.BarButtonItem m010102;
        private DevExpress.XtraBars.BarButtonItem m010103;
        private DevExpress.XtraBars.BarButtonItem m010201;
        private DevExpress.XtraBars.BarButtonItem m010202;
        private DevExpress.XtraBars.BarButtonItem m010203;
        private DevExpress.XtraBars.BarButtonItem m010301;
        private DevExpress.XtraBars.BarButtonItem m010302;
        private DevExpress.XtraBars.BarButtonItem m010303;
        private DevExpress.XtraBars.BarButtonItem m010304;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0102;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0103;
    }
}

