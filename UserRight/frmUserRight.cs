using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRight
{

    public partial class frmUserRight : DevExpress.XtraEditors.XtraForm
    {
        private UserRightsEntities _userRightsEntities;
        public frmUserRight()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _userRightsEntities = new UserRightsEntities();
            gridControl.DataSource = _userRightsEntities.tblUser.ToList();
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
            btnSave.ItemClick += BtnSave_ItemClick;
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            treeList.Focus();
            var user = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["UserName"]);
            var nodes = treeList.GetNodeList();
            foreach (var item in nodes)
            {
                var uf = new tblUserFunctions();
                var _menu = item.GetDisplayText(colMenu);
                var check = _userRightsEntities.tblUserFunctions.Where(x => x.UserName == user.ToString() && x.Menu == _menu).FirstOrDefault();
                if (check != null)
                    uf.ID = check.ID;
                uf.UserName = user.ToString();
                uf.Menu = _menu;
                uf.SetTime = DateTime.Now;
                uf.AllowAdd = (bool)(item.GetValue(colAdd) ?? false);
                uf.AllowEdit = (bool)(item.GetValue(colEdit) ?? false);
                uf.AllowDelete = (bool)(item.GetValue(colDel) ?? false);
                uf.Active = (bool)(item.GetValue(colActive) ?? false);
                _userRightsEntities.tblUserFunctions.AddOrUpdate(uf);
            }
            _userRightsEntities.SaveChanges();
            MessageBox.Show("Success");
            treeList.Refresh();
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var user = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["UserName"]);
            var dt = from a in _userRightsEntities.tblFunctions.Where(x => x.Applications == "PQND")
                     join b in _userRightsEntities.tblUserFunctions.Where(x => x.UserName == user.ToString())
                     on a.Menu equals b.Menu
                     into ab
                     from bc in ab.DefaultIfEmpty()
                     select new UserRights
                     {
                         UserName = bc.UserName,
                         Menu = a.Menu,
                         Description = a.Descriptions,
                         AllowAdd = bc.AllowAdd,
                         AllowEdit = bc.AllowEdit,
                         AllowDel = bc.AllowDelete,
                         Active = bc.Active,
                         ParentMenu = a.ParentMenu
                     };

            treeList.DataSource = dt.ToList();
            treeList.ExpandAll();
        }

        public class UserRights
        {
            public string UserName { get; set; }
            public string Menu { get; set; }
            public string Description { get; set; }
            public bool? AllowAdd { get; set; }
            public bool? AllowEdit { get; set; }
            public bool? AllowDel { get; set; }
            public bool? Active { get; set; }

            public string ParentMenu { get; set; }

        }
    }
}