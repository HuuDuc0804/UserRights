namespace UserRight
{
    partial class frmUserRight
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAdd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEdit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDisable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.treeList);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(899, 602);
            this.splitContainerControl1.SplitterPosition = 312;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(312, 602);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser,
            this.colName});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colUser
            // 
            this.colUser.Caption = "User";
            this.colUser.FieldName = "UserName";
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.AllowEdit = false;
            this.colUser.OptionsColumn.AllowFocus = false;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "FullName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colMenu,
            this.colAdd,
            this.colEdit,
            this.colDel,
            this.colDisable});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(577, 602);
            this.treeList.TabIndex = 0;
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menu";
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.Visible = true;
            this.colMenu.VisibleIndex = 0;
            // 
            // colAdd
            // 
            this.colAdd.Caption = "Allow Add";
            this.colAdd.FieldName = "AllowAdd";
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 1;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Allow Edit";
            this.colEdit.FieldName = "AllowEdit";
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 2;
            // 
            // colDel
            // 
            this.colDel.Caption = "Allow Del";
            this.colDel.FieldName = "AllowDel";
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 3;
            // 
            // colDisable
            // 
            this.colDisable.Caption = "Active";
            this.colDisable.FieldName = "Active";
            this.colDisable.Name = "colDisable";
            this.colDisable.Visible = true;
            this.colDisable.VisibleIndex = 4;
            // 
            // frmUserRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 602);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmUserRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDisable;
    }
}