using DevExpress.XtraEditors.Filtering.Templates;
using System;

namespace SILS.Winform
{
    partial class MainForm
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
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pnSearch = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.pnDetailSearch = new System.Windows.Forms.Panel();
            this.txbPublisher = new DevExpress.XtraEditors.TextEdit();
            this.txbAuthorSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnDetailSearch = new System.Windows.Forms.CheckBox();
            this.txbPublishedYear = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.pnDetailSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAuthorSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublishedYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(632, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnSearch.Controls.Add(this.textEdit1);
            this.pnSearch.Controls.Add(this.lblTitle);
            this.pnSearch.Controls.Add(this.pnDetailSearch);
            this.pnSearch.Controls.Add(this.btnDetailSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Location = new System.Drawing.Point(85, 29);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(918, 559);
            this.pnSearch.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(94, 109);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.NullText = "도서 검색";
            this.textEdit1.Size = new System.Drawing.Size(402, 36);
            this.textEdit1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("HCR Dotum", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 52);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "도서를 검색하세요";
            // 
            // pnDetailSearch
            // 
            this.pnDetailSearch.Controls.Add(this.txbPublishedYear);
            this.pnDetailSearch.Controls.Add(this.txbPublisher);
            this.pnDetailSearch.Controls.Add(this.txbAuthorSearch);
            this.pnDetailSearch.Location = new System.Drawing.Point(94, 219);
            this.pnDetailSearch.Name = "pnDetailSearch";
            this.pnDetailSearch.Size = new System.Drawing.Size(521, 261);
            this.pnDetailSearch.TabIndex = 3;
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(16, 98);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublisher.Properties.Appearance.Options.UseFont = true;
            this.txbPublisher.Properties.NullText = "출판사";
            this.txbPublisher.Size = new System.Drawing.Size(334, 34);
            this.txbPublisher.TabIndex = 1;
            // 
            // txbAuthorSearch
            // 
            this.txbAuthorSearch.Location = new System.Drawing.Point(16, 26);
            this.txbAuthorSearch.Name = "txbAuthorSearch";
            this.txbAuthorSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthorSearch.Properties.Appearance.Options.UseFont = true;
            this.txbAuthorSearch.Properties.NullText = "저자 검색";
            this.txbAuthorSearch.Size = new System.Drawing.Size(334, 34);
            this.txbAuthorSearch.TabIndex = 0;
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.AutoSize = true;
            this.btnDetailSearch.Location = new System.Drawing.Point(502, 155);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(113, 22);
            this.btnDetailSearch.TabIndex = 2;
            this.btnDetailSearch.Text = "상세정보 검색";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            // 
            // txbPublishedYear
            // 
            this.txbPublishedYear.Location = new System.Drawing.Point(16, 171);
            this.txbPublishedYear.Name = "txbPublishedYear";
            this.txbPublishedYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublishedYear.Properties.Appearance.Options.UseFont = true;
            this.txbPublishedYear.Properties.NullText = "출판 연도";
            this.txbPublishedYear.Size = new System.Drawing.Size(334, 34);
            this.txbPublishedYear.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.pnDetailSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbPublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAuthorSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPublishedYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl pnSearch;
        private System.Windows.Forms.Panel pnDetailSearch;
        private System.Windows.Forms.CheckBox btnDetailSearch;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txbAuthorSearch;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txbPublisher;
        private DevExpress.XtraEditors.TextEdit txbPublishedYear;
    }
}

