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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        UserRightsEntities entities;
        public frmLogin()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            entities = new UserRightsEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = entities.tblUser.FirstOrDefault(x => x.UserName == txtUserName.Text.Trim() && x.Pass== txtPassword.Text.Trim());
            if (user!=null)
            {
                ClassUser.Username = user.UserName;
                var frm = new frmMain();
                frm.Show();
                this.Hide();
            }
        }
    }
}