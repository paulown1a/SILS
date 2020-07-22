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
            this.pnDetailSearch = new System.Windows.Forms.Panel();
            this.btnDetailSearch = new System.Windows.Forms.CheckBox();
            this.txbAuthorSearch = new SILS.Winform.Controls.TextBoxEx("저자 이름");
            this.txbPublishedYear = new SILS.Winform.Controls.TextBoxEx("출판 연도");
            this.txbPublisher = new SILS.Winform.Controls.TextBoxEx("출판사");
            this.txbSearch = new SILS.Winform.Controls.TextBoxEx("도서 제목");


            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnDetailSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbSearch.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbSearch.Location = new System.Drawing.Point(94, 101);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(521, 39);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.Text = "도서 제목";
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
            this.pnSearch.Controls.Add(this.pnDetailSearch);
            this.pnSearch.Controls.Add(this.btnDetailSearch);
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.txbSearch);
            this.pnSearch.Location = new System.Drawing.Point(167, 62);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(805, 527);
            this.pnSearch.TabIndex = 2;
            // 
            // pnDetailSearch
            // 
            this.pnDetailSearch.Controls.Add(this.txbPublisher);
            this.pnDetailSearch.Controls.Add(this.txbPublishedYear);
            this.pnDetailSearch.Controls.Add(this.txbAuthorSearch);
            this.pnDetailSearch.Location = new System.Drawing.Point(94, 201);
            this.pnDetailSearch.Name = "pnDetailSearch";
            this.pnDetailSearch.Size = new System.Drawing.Size(521, 235);
            this.pnDetailSearch.TabIndex = 3;
            // 
            // txbPublisher
            // 
            this.txbPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbPublisher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublisher.Location = new System.Drawing.Point(17, 125);
            this.txbPublisher.Multiline = true;
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(297, 32);
            this.txbPublisher.TabIndex = 6;
            this.txbPublisher.Text = "출판사";
            // 
            // txbPublishedYear
            // 
            this.txbPublishedYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbPublishedYear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPublishedYear.Location = new System.Drawing.Point(17, 74);
            this.txbPublishedYear.Multiline = true;
            this.txbPublishedYear.Name = "txbPublishedYear";
            this.txbPublishedYear.Size = new System.Drawing.Size(297, 32);
            this.txbPublishedYear.TabIndex = 5;
            this.txbPublishedYear.Text = "출판 연도";
            // 
            // txbAuthorSearch
            // 
            this.txbAuthorSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbAuthorSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthorSearch.ForeColor = System.Drawing.Color.Black;
            this.txbAuthorSearch.Location = new System.Drawing.Point(17, 24);
            this.txbAuthorSearch.Multiline = true;
            this.txbAuthorSearch.Name = "txbAuthorSearch";
            this.txbAuthorSearch.Size = new System.Drawing.Size(297, 32);
            this.txbAuthorSearch.TabIndex = 4;
            this.txbAuthorSearch.Text = "저자 이름";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.pnSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pnSearch)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnDetailSearch.ResumeLayout(false);
            this.pnDetailSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl pnSearch;
        
        private System.Windows.Forms.Panel pnDetailSearch;
        private System.Windows.Forms.CheckBox btnDetailSearch;
        private SILS.Winform.Controls.TextBoxEx txbSearch;
        private SILS.Winform.Controls.TextBoxEx txbPublisher;
        private SILS.Winform.Controls.TextBoxEx txbPublishedYear;
        private SILS.Winform.Controls.TextBoxEx txbAuthorSearch;
    }
}

