namespace SILS.Winform
{
    partial class ReportedForm
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
            this.gdReportList = new DevExpress.XtraGrid.GridControl();
            this.bdsReport = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReportCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbReport = new System.Windows.Forms.CheckBox();
            this.cbLibrary = new System.Windows.Forms.CheckBox();
            this.cbbReportType = new System.Windows.Forms.ComboBox();
            this.bdsCodeReported = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cbbLibrary = new System.Windows.Forms.ComboBox();
            this.bdsLibraryReported = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gdReportList);
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(731, 444);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gdReportList
            // 
            this.gdReportList.DataSource = this.bdsReport;
            this.gdReportList.Location = new System.Drawing.Point(12, 163);
            this.gdReportList.MainView = this.gridView1;
            this.gdReportList.Name = "gdReportList";
            this.gdReportList.Size = new System.Drawing.Size(707, 269);
            this.gdReportList.TabIndex = 5;
            this.gdReportList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsReport
            // 
            this.bdsReport.DataSource = typeof(SILS.Data.Report);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReportCodeName,
            this.colBookName});
            this.gridView1.GridControl = this.gdReportList;
            this.gridView1.Name = "gridView1";
            // 
            // colReportCodeName
            // 
            this.colReportCodeName.Caption = "오류 종류";
            this.colReportCodeName.FieldName = "ReportCodeName";
            this.colReportCodeName.MinWidth = 25;
            this.colReportCodeName.Name = "colReportCodeName";
            this.colReportCodeName.Visible = true;
            this.colReportCodeName.VisibleIndex = 1;
            this.colReportCodeName.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbReport);
            this.panel1.Controls.Add(this.cbLibrary);
            this.panel1.Controls.Add(this.cbbReportType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbbLibrary);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 147);
            this.panel1.TabIndex = 4;
            // 
            // cbReport
            // 
            this.cbReport.AutoSize = true;
            this.cbReport.Location = new System.Drawing.Point(497, 83);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(18, 17);
            this.cbReport.TabIndex = 5;
            this.cbReport.UseVisualStyleBackColor = true;
            // 
            // cbLibrary
            // 
            this.cbLibrary.AutoSize = true;
            this.cbLibrary.Location = new System.Drawing.Point(497, 38);
            this.cbLibrary.Name = "cbLibrary";
            this.cbLibrary.Size = new System.Drawing.Size(18, 17);
            this.cbLibrary.TabIndex = 4;
            this.cbLibrary.UseVisualStyleBackColor = true;
            // 
            // cbbReportType
            // 
            this.cbbReportType.DataSource = this.bdsCodeReported;
            this.cbbReportType.DisplayMember = "Name";
            this.cbbReportType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbReportType.FormattingEnabled = true;
            this.cbbReportType.Location = new System.Drawing.Point(79, 78);
            this.cbbReportType.Name = "cbbReportType";
            this.cbbReportType.Size = new System.Drawing.Size(412, 26);
            this.cbbReportType.TabIndex = 3;
            this.cbbReportType.ValueMember = "CodeId";
            // 
            // bdsCodeReported
            // 
            this.bdsCodeReported.DataSource = typeof(SILS.Data.Code);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(556, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검 색 (&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbLibrary
            // 
            this.cbbLibrary.DataSource = this.bdsLibraryReported;
            this.cbbLibrary.DisplayMember = "Name";
            this.cbbLibrary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLibrary.FormattingEnabled = true;
            this.cbbLibrary.Location = new System.Drawing.Point(79, 36);
            this.cbbLibrary.Name = "cbbLibrary";
            this.cbbLibrary.Size = new System.Drawing.Size(412, 26);
            this.cbbLibrary.TabIndex = 0;
            this.cbbLibrary.ValueMember = "LibraryId";
            // 
            // bdsLibraryReported
            // 
            this.bdsLibraryReported.DataSource = typeof(SILS.Data.Library);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(731, 444);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(711, 151);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gdReportList;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(711, 273);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // colBookName
            // 
            this.colBookName.Caption = "책 이름";
            this.colBookName.FieldName = "BookName";
            this.colBookName.MinWidth = 25;
            this.colBookName.Name = "colBookName";
            this.colBookName.Visible = true;
            this.colBookName.VisibleIndex = 0;
            this.colBookName.Width = 94;
            // 
            // ReportedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 444);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ReportedForm";
            this.Text = "오류 정정요청 목록";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gdReportList;
        private System.Windows.Forms.BindingSource bdsReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbReport;
        private System.Windows.Forms.CheckBox cbLibrary;
        private System.Windows.Forms.ComboBox cbbReportType;
        private System.Windows.Forms.BindingSource bdsCodeReported;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ComboBox cbbLibrary;
        private System.Windows.Forms.BindingSource bdsLibraryReported;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colReportCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colBookName;
    }
}