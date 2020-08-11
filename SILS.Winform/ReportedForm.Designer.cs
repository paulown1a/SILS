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
            this.bdsReport = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCodeReported = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLibraryReported = new System.Windows.Forms.BindingSource(this.components);
            this.tbcLibrary = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbReportedCode = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBookName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearchReportCode = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbLibraryId = new System.Windows.Forms.ComboBox();
            this.gdReport = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReportCodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearchLibrary = new DevExpress.XtraEditors.SimpleButton();
            this.colLibraryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcLibrary)).BeginInit();
            this.tbcLibrary.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsReport
            // 
            this.bdsReport.DataSource = typeof(SILS.Data.Report);
            // 
            // bdsCodeReported
            // 
            this.bdsCodeReported.DataSource = typeof(SILS.Data.Code);
            // 
            // bdsLibraryReported
            // 
            this.bdsLibraryReported.DataSource = typeof(SILS.Data.Library);
            // 
            // tbcLibrary
            // 
            this.tbcLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLibrary.Location = new System.Drawing.Point(0, 0);
            this.tbcLibrary.Name = "tbcLibrary";
            this.tbcLibrary.SelectedTabPage = this.xtraTabPage2;
            this.tbcLibrary.Size = new System.Drawing.Size(692, 482);
            this.tbcLibrary.TabIndex = 0;
            this.tbcLibrary.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(685, 446);
            this.xtraTabPage2.Text = "에러종류 검색";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbReportedCode);
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.btnSearchReportCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 446);
            this.panel2.TabIndex = 5;
            // 
            // cbbReportedCode
            // 
            this.cbbReportedCode.DataSource = this.bdsCodeReported;
            this.cbbReportedCode.DisplayMember = "Name";
            this.cbbReportedCode.FormattingEnabled = true;
            this.cbbReportedCode.Location = new System.Drawing.Point(108, 62);
            this.cbbReportedCode.Name = "cbbReportedCode";
            this.cbbReportedCode.Size = new System.Drawing.Size(371, 26);
            this.cbbReportedCode.TabIndex = 3;
            this.cbbReportedCode.ValueMember = "CodeId";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsReport;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(685, 297);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBookName1,
            this.colLibraryName});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colBookName1
            // 
            this.colBookName1.FieldName = "BookName";
            this.colBookName1.MinWidth = 25;
            this.colBookName1.Name = "colBookName1";
            this.colBookName1.Visible = true;
            this.colBookName1.VisibleIndex = 0;
            this.colBookName1.Width = 94;
            // 
            // btnSearchReportCode
            // 
            this.btnSearchReportCode.Location = new System.Drawing.Point(529, 62);
            this.btnSearchReportCode.Name = "btnSearchReportCode";
            this.btnSearchReportCode.Size = new System.Drawing.Size(94, 29);
            this.btnSearchReportCode.TabIndex = 2;
            this.btnSearchReportCode.Text = "검 색 (&S)";
            this.btnSearchReportCode.Click += new System.EventHandler(this.btnSearchReportCode_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(685, 446);
            this.xtraTabPage1.Text = "도서관 검색";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbLibraryId);
            this.panel1.Controls.Add(this.gdReport);
            this.panel1.Controls.Add(this.btnSearchLibrary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 446);
            this.panel1.TabIndex = 4;
            // 
            // cbbLibraryId
            // 
            this.cbbLibraryId.DataSource = this.bdsLibraryReported;
            this.cbbLibraryId.DisplayMember = "Name";
            this.cbbLibraryId.FormattingEnabled = true;
            this.cbbLibraryId.Location = new System.Drawing.Point(108, 62);
            this.cbbLibraryId.Name = "cbbLibraryId";
            this.cbbLibraryId.Size = new System.Drawing.Size(371, 26);
            this.cbbLibraryId.TabIndex = 3;
            this.cbbLibraryId.ValueMember = "LibraryId";
            // 
            // gdReport
            // 
            this.gdReport.DataSource = this.bdsReport;
            this.gdReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gdReport.Location = new System.Drawing.Point(0, 149);
            this.gdReport.MainView = this.gridView1;
            this.gdReport.Name = "gdReport";
            this.gdReport.Size = new System.Drawing.Size(685, 297);
            this.gdReport.TabIndex = 0;
            this.gdReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBookName,
            this.colReportCodeName});
            this.gridView1.GridControl = this.gdReport;
            this.gridView1.Name = "gridView1";
            // 
            // colBookName
            // 
            this.colBookName.FieldName = "BookName";
            this.colBookName.MinWidth = 25;
            this.colBookName.Name = "colBookName";
            this.colBookName.Visible = true;
            this.colBookName.VisibleIndex = 0;
            this.colBookName.Width = 94;
            // 
            // colReportCodeName
            // 
            this.colReportCodeName.FieldName = "ReportCodeName";
            this.colReportCodeName.MinWidth = 25;
            this.colReportCodeName.Name = "colReportCodeName";
            this.colReportCodeName.Visible = true;
            this.colReportCodeName.VisibleIndex = 1;
            this.colReportCodeName.Width = 94;
            // 
            // btnSearchLibrary
            // 
            this.btnSearchLibrary.Location = new System.Drawing.Point(529, 62);
            this.btnSearchLibrary.Name = "btnSearchLibrary";
            this.btnSearchLibrary.Size = new System.Drawing.Size(94, 29);
            this.btnSearchLibrary.TabIndex = 2;
            this.btnSearchLibrary.Text = "검 색 (&S)";
            this.btnSearchLibrary.Click += new System.EventHandler(this.btnSearchLibrary_Click);
            // 
            // colLibraryName
            // 
            this.colLibraryName.FieldName = "LibraryName";
            this.colLibraryName.MinWidth = 25;
            this.colLibraryName.Name = "colLibraryName";
            this.colLibraryName.Visible = true;
            this.colLibraryName.VisibleIndex = 1;
            this.colLibraryName.Width = 94;
            // 
            // ReportedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 482);
            this.Controls.Add(this.tbcLibrary);
            this.Name = "ReportedForm";
            this.Text = "오류 정정요청 목록";
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcLibrary)).EndInit();
            this.tbcLibrary.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsReport;
        private System.Windows.Forms.BindingSource bdsCodeReported;
        private System.Windows.Forms.BindingSource bdsLibraryReported;
        private DevExpress.XtraTab.XtraTabControl tbcLibrary;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gdReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnSearchLibrary;
        private System.Windows.Forms.ComboBox cbbLibraryId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbReportedCode;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnSearchReportCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBookName1;
        private DevExpress.XtraGrid.Columns.GridColumn colBookName;
        private DevExpress.XtraGrid.Columns.GridColumn colReportCodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colLibraryName;
    }
}