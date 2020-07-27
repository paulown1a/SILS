using DevExpress.XtraEditors.Filtering.Templates;
using System;

namespace SILS.Winform
{
    partial class BookSearch
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
            this.btnDetailSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pnSearch = new DevExpress.XtraEditors.PanelControl();
            this.pnSimpleSearch = new System.Windows.Forms.Panel();
            this.txbSimpleName = new DevExpress.XtraEditors.TextEdit();
            this.btnSimpleSearch = new DevExpress.XtraEditors.SimpleButton();
            this.chbUnclicked = new System.Windows.Forms.CheckBox();
            this.pnDetailSearch = new System.Windows.Forms.Panel();
            this.txbName = new DevExpress.XtraEditors.TextEdit();
            this.txbPublishedYear = new DevExpress.XtraEditors.TextEdit();
            this.chbClicked = new System.Windows.Forms.CheckBox();
            this.txbPublisher = new DevExpress.XtraEditors.TextEdit();
            this.txbAuthor = new DevExpress.XtraEditors.TextEdit();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnSimpleSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSimpleName.Properties)).BeginInit();
            this.pnDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublishedYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAuthor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailSearch.Appearance.Options.UseFont = true;
            this.btnDetailSearch.Location = new System.Drawing.Point(668, 50);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(95, 39);
            this.btnDetailSearch.TabIndex = 1;
            this.btnDetailSearch.Text = "Search";
            this.btnDetailSearch.Click += new System.EventHandler(this.btnDetailSearch_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnSimpleSearch);
            this.pnSearch.Controls.Add(this.pnDetailSearch);
            this.pnSearch.Controls.Add(this.lblTitle);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(912, 388);
            this.pnSearch.TabIndex = 2;
            // 
            // pnSimpleSearch
            // 
            this.pnSimpleSearch.Controls.Add(this.txbSimpleName);
            this.pnSimpleSearch.Controls.Add(this.btnSimpleSearch);
            this.pnSimpleSearch.Controls.Add(this.chbUnclicked);
            this.pnSimpleSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSimpleSearch.Location = new System.Drawing.Point(2, 103);
            this.pnSimpleSearch.Name = "pnSimpleSearch";
            this.pnSimpleSearch.Size = new System.Drawing.Size(908, 283);
            this.pnSimpleSearch.TabIndex = 6;
            // 
            // txbSimpleName
            // 
            this.txbSimpleName.Location = new System.Drawing.Point(34, 118);
            this.txbSimpleName.Name = "txbSimpleName";
            this.txbSimpleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSimpleName.Properties.Appearance.Options.UseFont = true;
            this.txbSimpleName.Properties.NullText = "도서 검색";
            this.txbSimpleName.Size = new System.Drawing.Size(589, 36);
            this.txbSimpleName.TabIndex = 5;
            // 
            // btnSimpleSearch
            // 
            this.btnSimpleSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpleSearch.Appearance.Options.UseFont = true;
            this.btnSimpleSearch.Location = new System.Drawing.Point(650, 115);
            this.btnSimpleSearch.Name = "btnSimpleSearch";
            this.btnSimpleSearch.Size = new System.Drawing.Size(95, 39);
            this.btnSimpleSearch.TabIndex = 1;
            this.btnSimpleSearch.Text = "Search";
            this.btnSimpleSearch.Click += new System.EventHandler(this.btnSimpleSearch_Click);
            // 
            // chbUnclicked
            // 
            this.chbUnclicked.AutoSize = true;
            this.chbUnclicked.Location = new System.Drawing.Point(599, 174);
            this.chbUnclicked.Name = "chbUnclicked";
            this.chbUnclicked.Size = new System.Drawing.Size(113, 22);
            this.chbUnclicked.TabIndex = 2;
            this.chbUnclicked.Text = "상세정보 검색";
            this.chbUnclicked.UseVisualStyleBackColor = true;
            this.chbUnclicked.CheckedChanged += new System.EventHandler(this.chbUnclicked_CheckedChanged);
            // 
            // pnDetailSearch
            // 
            this.pnDetailSearch.Controls.Add(this.txbName);
            this.pnDetailSearch.Controls.Add(this.txbPublishedYear);
            this.pnDetailSearch.Controls.Add(this.btnDetailSearch);
            this.pnDetailSearch.Controls.Add(this.chbClicked);
            this.pnDetailSearch.Controls.Add(this.txbPublisher);
            this.pnDetailSearch.Controls.Add(this.txbAuthor);
            this.pnDetailSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDetailSearch.Location = new System.Drawing.Point(2, 103);
            this.pnDetailSearch.Name = "pnDetailSearch";
            this.pnDetailSearch.Size = new System.Drawing.Size(908, 283);
            this.pnDetailSearch.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(34, 48);
            this.txbName.Name = "txbName";
            this.txbName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Properties.Appearance.Options.UseFont = true;
            this.txbName.Properties.NullText = "도서 검색";
            this.txbName.Size = new System.Drawing.Size(610, 36);
            this.txbName.TabIndex = 5;
            // 
            // txbPublishedYear
            // 
            this.txbPublishedYear.Location = new System.Drawing.Point(34, 214);
            this.txbPublishedYear.Name = "txbPublishedYear";
            this.txbPublishedYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublishedYear.Properties.Appearance.Options.UseFont = true;
            this.txbPublishedYear.Properties.NullText = "출판 연도";
            this.txbPublishedYear.Size = new System.Drawing.Size(610, 34);
            this.txbPublishedYear.TabIndex = 2;
            // 
            // chbClicked
            // 
            this.chbClicked.AutoSize = true;
            this.chbClicked.Location = new System.Drawing.Point(531, 106);
            this.chbClicked.Name = "chbClicked";
            this.chbClicked.Size = new System.Drawing.Size(113, 22);
            this.chbClicked.TabIndex = 2;
            this.chbClicked.Text = "상세정보 검색";
            this.chbClicked.UseVisualStyleBackColor = true;
            this.chbClicked.CheckedChanged += new System.EventHandler(this.chbClicked_CheckedChanged);
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(34, 174);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublisher.Properties.Appearance.Options.UseFont = true;
            this.txbPublisher.Properties.NullText = "출판사";
            this.txbPublisher.Size = new System.Drawing.Size(610, 34);
            this.txbPublisher.TabIndex = 1;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(34, 134);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.Properties.Appearance.Options.UseFont = true;
            this.txbAuthor.Properties.NullText = "저자 검색";
            this.txbAuthor.Size = new System.Drawing.Size(610, 34);
            this.txbAuthor.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("HCR Dotum", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(908, 101);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "  도서를 검색하세요";
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 388);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookSearch";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSimpleSearch.ResumeLayout(false);
            this.pnSimpleSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSimpleName.Properties)).EndInit();
            this.pnDetailSearch.ResumeLayout(false);
            this.pnDetailSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublishedYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAuthor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDetailSearch;
        private DevExpress.XtraEditors.PanelControl pnSearch;
        private System.Windows.Forms.Panel pnDetailSearch;
        private System.Windows.Forms.CheckBox chbClicked;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txbAuthor;
        private DevExpress.XtraEditors.TextEdit txbName;
        private DevExpress.XtraEditors.TextEdit txbPublisher;
        private DevExpress.XtraEditors.TextEdit txbPublishedYear;
        private System.Windows.Forms.Panel pnSimpleSearch;
        private DevExpress.XtraEditors.TextEdit txbSimpleName;
        private DevExpress.XtraEditors.SimpleButton btnSimpleSearch;
        private System.Windows.Forms.CheckBox chbUnclicked;
    }
}

