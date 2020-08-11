namespace SILS.Winform
{
    partial class LibraryListForm
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbGuGun = new System.Windows.Forms.ComboBox();
            this.bdsGuGun = new System.Windows.Forms.BindingSource(this.components);
            this.cbbSiDo = new System.Windows.Forms.ComboBox();
            this.bdsSiDo = new System.Windows.Forms.BindingSource(this.components);
            this.grvLibrary = new DevExpress.XtraGrid.GridControl();
            this.bdsLibrary = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblSiDo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblGuGun = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSiDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSiDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGuGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbGuGun);
            this.layoutControl1.Controls.Add(this.cbbSiDo);
            this.layoutControl1.Controls.Add(this.grvLibrary);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 540);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbGuGun
            // 
            this.cbbGuGun.DataSource = this.bdsGuGun;
            this.cbbGuGun.DisplayMember = "Name";
            this.cbbGuGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGuGun.FormattingEnabled = true;
            this.cbbGuGun.Location = new System.Drawing.Point(77, 44);
            this.cbbGuGun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGuGun.Name = "cbbGuGun";
            this.cbbGuGun.Size = new System.Drawing.Size(497, 26);
            this.cbbGuGun.TabIndex = 9;
            this.cbbGuGun.ValueMember = "CodeId";
            this.cbbGuGun.SelectedIndexChanged += new System.EventHandler(this.cbbGuGun_SelectedIndexChanged);
            // 
            // bdsGuGun
            // 
            this.bdsGuGun.DataSource = typeof(SILS.Data.Code);
            // 
            // cbbSiDo
            // 
            this.cbbSiDo.DataSource = this.bdsSiDo;
            this.cbbSiDo.DisplayMember = "Name";
            this.cbbSiDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSiDo.FormattingEnabled = true;
            this.cbbSiDo.Location = new System.Drawing.Point(77, 14);
            this.cbbSiDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSiDo.Name = "cbbSiDo";
            this.cbbSiDo.Size = new System.Drawing.Size(497, 26);
            this.cbbSiDo.TabIndex = 8;
            this.cbbSiDo.ValueMember = "CodeId";
            this.cbbSiDo.SelectedIndexChanged += new System.EventHandler(this.cbbSiDo_SelectedIndexChanged);
            // 
            // bdsSiDo
            // 
            this.bdsSiDo.DataSource = typeof(SILS.Data.Code);
            // 
            // grvLibrary
            // 
            this.grvLibrary.DataSource = this.bdsLibrary;
            this.grvLibrary.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grvLibrary.Location = new System.Drawing.Point(12, 128);
            this.grvLibrary.MainView = this.gridView1;
            this.grvLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvLibrary.Name = "grvLibrary";
            this.grvLibrary.Size = new System.Drawing.Size(776, 398);
            this.grvLibrary.TabIndex = 4;
            this.grvLibrary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvLibrary.DoubleClick += new System.EventHandler(this.grvLibrary_DoubleClick);
            // 
            // bdsLibrary
            // 
            this.bdsLibrary.DataSource = typeof(SILS.Data.Library);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAddress,
            this.colWebsite,
            this.colPhoneNumber});
            this.gridView1.DetailHeight = 420;
            this.gridView1.GridControl = this.grvLibrary;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "도서관명";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "주소";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 94;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "웹사이트";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.MinWidth = 25;
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.AllowEdit = false;
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 2;
            this.colWebsite.Width = 94;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "전화번호";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 25;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.OptionsColumn.AllowEdit = false;
            this.colPhoneNumber.OptionsColumn.ReadOnly = true;
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            this.colPhoneNumber.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lblSiDo,
            this.lblGuGun,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grvLibrary;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 402);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lblSiDo
            // 
            this.lblSiDo.Control = this.cbbSiDo;
            this.lblSiDo.Location = new System.Drawing.Point(0, 0);
            this.lblSiDo.Name = "lblSiDo";
            this.lblSiDo.Size = new System.Drawing.Size(566, 30);
            this.lblSiDo.Text = " 시 / 도 : ";
            this.lblSiDo.TextSize = new System.Drawing.Size(62, 18);
            // 
            // lblGuGun
            // 
            this.lblGuGun.Control = this.cbbGuGun;
            this.lblGuGun.Location = new System.Drawing.Point(0, 30);
            this.lblGuGun.Name = "lblGuGun";
            this.lblGuGun.Size = new System.Drawing.Size(566, 30);
            this.lblGuGun.Text = " 구 / 군 : ";
            this.lblGuGun.TextSize = new System.Drawing.Size(62, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(566, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(214, 60);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(780, 54);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LibraryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LibraryListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관 목록";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGuGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSiDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSiDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGuGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grvLibrary;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bdsSiDo;
        private System.Windows.Forms.BindingSource bdsLibrary;
        private System.Windows.Forms.BindingSource bdsGuGun;
        private System.Windows.Forms.ComboBox cbbGuGun;
        private System.Windows.Forms.ComboBox cbbSiDo;
        private DevExpress.XtraLayout.LayoutControlItem lblSiDo;
        private DevExpress.XtraLayout.LayoutControlItem lblGuGun;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}