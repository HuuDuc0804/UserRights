using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRight
{
    
    public partial class frmUserRight : DevExpress.XtraEditors.XtraForm
    {
        private UserRightEntities _userRightsEntities;
        public frmUserRight()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            _userRightsEntities = new UserRightEntities();
            gridControl.DataSource = _userRightsEntities.tblUser.ToList();
        }
        public class UserRights
        {
            public string Menu { get; set; }
            public bool AllowAdd { get; set; }
            public bool AllowEdit { get; set; }
            public bool AllowDel { get; set; }
            public bool Active { get; set; }

        }
    }
}