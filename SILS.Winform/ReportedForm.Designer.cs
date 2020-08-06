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
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcLibrary)).BeginInit();
            this.tbcLibrary.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.tbcLibrary.SelectedTabPage = this.xtraTabPage1;
            this.tbcLibrary.Size = new System.Drawing.Size(899, 421);
            this.tbcLibrary.TabIndex = 0;
            this.tbcLibrary.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(892, 385);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(892, 385);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 177);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(892, 208);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ReportedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 421);
            this.Controls.Add(this.tbcLibrary);
            this.Name = "ReportedForm";
            this.Text = "오류 정정요청 목록";
            ((System.ComponentModel.ISupportInitialize)(this.bdsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLibraryReported)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcLibrary)).EndInit();
            this.tbcLibrary.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsReport;
        private System.Windows.Forms.BindingSource bdsCodeReported;
        private System.Windows.Forms.BindingSource bdsLibraryReported;
        private DevExpress.XtraTab.XtraTabControl tbcLibrary;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
    }
}