using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserRight
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UserRightsEntities entities;
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            entities = new UserRightsEntities();
            LoadPermission();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void m010201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmUserRight();
            frm.ShowDialog();
        }
        private void SavePermission()
        {
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                var pageF = new tblFunctions();
                pageF.Menu = page.Name;
                pageF.Applications = "PQND";
                pageF.Descriptions = page.Text;
                pageF.ParentMenu = null;
                entities.tblFunctions.AddOrUpdate(pageF);
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    var pageGroupF = new tblFunctions();
                    pageGroupF.Menu = pageGroup.Name;
                    pageGroupF.Applications = "PQND";
                    pageGroupF.Descriptions = pageGroup.Text;
                    pageGroupF.ParentMenu = page.Name;
                    entities.tblFunctions.AddOrUpdate(pageGroupF);
                    foreach (BarItemLink item in pageGroup.ItemLinks)
                    {
                        var itemF = new tblFunctions();
                        itemF.Menu = item.Item.Name;
                        itemF.Applications = "PQND";
                        itemF.Descriptions = item.Item.Caption;
                        itemF.ParentMenu = pageGroup.Name;
                        entities.tblFunctions.AddOrUpdate(itemF);
                    }
                }
            }
            entities.SaveChanges();
        }
        private void LoadPermission()
        {
            var dt = (from a in entities.tblUserFunctions
                      join b in entities.tblFunctions
                      on a.Menu equals b.Menu
                      where b.Applications == "PQND" && a.UserName == ClassUser.Username
                      select a).ToList();
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                foreach (var item in dt)
                {
                    if (item.Menu == page.Name && item.Active != true)
                    {
                        page.Visible = false;
                    }
                }
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    foreach (var item in dt)
                    {
                        if (item.Menu == pageGroup.Name && item.Active != true)
                        {
                            pageGroup.Visible = false;
                        }
                    }
                    foreach (BarItemLink itemLink in pageGroup.ItemLinks)
                    {
                        foreach (var item in dt)
                        {
                            if (item.Menu == itemLink.Item.Name && item.Active != true)
                            {
                                itemLink.Visible = false;
                            }
                        }
                    }
                }
            }
            entities.SaveChanges();
        }
    }
}
