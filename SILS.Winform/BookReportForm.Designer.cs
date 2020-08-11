namespace SILS.Winform
{
    partial class BookReportForm
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
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbbReportCode = new System.Windows.Forms.ComboBox();
            this.bdsCode = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(149, 96);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 29);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "신 청 (&R)";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "취 소 (&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbReportCode
            // 
            this.cbbReportCode.DataSource = this.bdsCode;
            this.cbbReportCode.DisplayMember = "Name";
            this.cbbReportCode.FormattingEnabled = true;
            this.cbbReportCode.Location = new System.Drawing.Point(12, 36);
            this.cbbReportCode.Name = "cbbReportCode";
            this.cbbReportCode.Size = new System.Drawing.Size(342, 26);
            this.cbbReportCode.TabIndex = 3;
            this.cbbReportCode.ValueMember = "CodeId";
            // 
            // bdsCode
            // 
            this.bdsCode.DataSource = typeof(SILS.Data.Code);
            // 
            // BookReportForm
            // 
            this.AcceptButton = this.btnReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 142);
            this.ControlBox = false;
            this.Controls.Add(this.cbbReportCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReport);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "정정 신청";
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ComboBox cbbReportCode;
        private System.Windows.Forms.BindingSource bdsCode;
    }
}