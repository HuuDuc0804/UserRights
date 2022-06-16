using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserRight
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserRightEntities entities;
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            entities = new UserRightEntities();
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                var pageF = new tblFunctions();
                pageF.Menu = page.Name;
                pageF.Applications = "PQND";
                pageF.Descriptions = page.Text;
                pageF.ParentMenu = null;
                entities.tblFunctions.Add(pageF);
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    var pageGroupF = new tblFunctions();
                    pageGroupF.Menu = pageGroup.Name;
                    pageGroupF.Applications = "PQND";
                    pageGroupF.Descriptions = pageGroup.Text;
                    pageGroupF.ParentMenu = page.Name;
                    entities.tblFunctions.Add(pageGroupF);
                    foreach (BarItemLink item in pageGroup.ItemLinks)
                    {
                        var itemF = new tblFunctions();
                        itemF.Menu = item.Item.Name;
                        itemF.Applications = "PQND";
                        itemF.Descriptions = item.Item.Caption;
                        itemF.ParentMenu = pageGroup.Name;
                        entities.tblFunctions.Add(itemF);
                    }
                }
            }
            entities.SaveChanges();
        }
        private void m010201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmUserRight();
            frm.ShowDialog();
        }
    }
}
