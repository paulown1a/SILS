namespace SILS.Winform
{
    partial class BookListForm
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
            this.pnSearch = new DevExpress.XtraEditors.PanelControl();
            this.pnDetailSearch = new System.Windows.Forms.Panel();
            this.lblSearchText = new DevExpress.XtraEditors.LabelControl();
            this.txbName = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.grvBooks = new DevExpress.XtraGrid.GridControl();
            this.bdsBook = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublicationYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnDetailSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1098, 660);
            this.pnSearch.TabIndex = 3;
            // 
            // pnDetailSearch
            // 
            this.pnDetailSearch.Controls.Add(this.lblSearchText);
            this.pnDetailSearch.Controls.Add(this.txbName);
            this.pnDetailSearch.Controls.Add(this.btnSearch);
            this.pnDetailSearch.Controls.Add(this.grvBooks);
            this.pnDetailSearch.Location = new System.Drawing.Point(32, 33);
            this.pnDetailSearch.Name = "pnDetailSearch";
            this.pnDetailSearch.Size = new System.Drawing.Size(1029, 592);
            this.pnDetailSearch.TabIndex = 3;
            // 
            // lblSearchText
            // 
            this.lblSearchText.Location = new System.Drawing.Point(21, 107);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(79, 18);
            this.lblSearchText.TabIndex = 7;
            this.lblSearchText.Text = " \"\" 검색 결과";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(21, 39);
            this.txbName.Name = "txbName";
            this.txbName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Properties.Appearance.Options.UseFont = true;
            this.txbName.Properties.NullText = "도서 검색";
            this.txbName.Size = new System.Drawing.Size(837, 36);
            this.txbName.TabIndex = 6;
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbName_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(911, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grvBooks
            // 
            this.grvBooks.DataSource = this.bdsBook;
            this.grvBooks.Location = new System.Drawing.Point(21, 131);
            this.grvBooks.MainView = this.gridView1;
            this.grvBooks.Name = "grvBooks";
            this.grvBooks.Size = new System.Drawing.Size(985, 425);
            this.grvBooks.TabIndex = 0;
            this.grvBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvBooks.DoubleClick += new System.EventHandler(this.grvBooks_DoubleClick);
            // 
            // bdsBook
            // 
            this.bdsBook.DataSource = typeof(SILS.Data.Book);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colAuthor,
            this.colPublisher,
            this.colPublicationYear});
            this.gridView1.GridControl = this.grvBooks;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "도서명";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "저자";
            this.colAuthor.FieldName = "Author";
            this.colAuthor.MinWidth = 25;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.OptionsColumn.AllowEdit = false;
            this.colAuthor.OptionsColumn.ReadOnly = true;
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 1;
            this.colAuthor.Width = 94;
            // 
            // colPublisher
            // 
            this.colPublisher.Caption = "출판사";
            this.colPublisher.FieldName = "Publisher";
            this.colPublisher.MinWidth = 25;
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.OptionsColumn.AllowEdit = false;
            this.colPublisher.OptionsColumn.ReadOnly = true;
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 2;
            this.colPublisher.Width = 94;
            // 
            // colPublicationYear
            // 
            this.colPublicationYear.Caption = "출판 연도";
            this.colPublicationYear.FieldName = "PublicationYear";
            this.colPublicationYear.MinWidth = 25;
            this.colPublicationYear.Name = "colPublicationYear";
            this.colPublicationYear.OptionsColumn.AllowEdit = false;
            this.colPublicationYear.OptionsColumn.ReadOnly = true;
            this.colPublicationYear.Visible = true;
            this.colPublicationYear.VisibleIndex = 3;
            this.colPublicationYear.Width = 94;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.pnSearch);
            this.Name = "BookListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서 목록";
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnDetailSearch.ResumeLayout(false);
            this.pnDetailSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnSearch;
        private System.Windows.Forms.Panel pnDetailSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl grvBooks;
        private DevExpress.XtraEditors.TextEdit txbName;
        private System.Windows.Forms.BindingSource bdsBook;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicationYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
        private DevExpress.XtraEditors.LabelControl lblSearchText;
    }
}