using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SILS.Data;

namespace SILS.Winform
{
    public partial class BookReportForm : DevExpress.XtraEditors.XtraForm
    {
        int _bookId;
        private BookReportForm()
        {
            InitializeComponent();
            bdsCode.DataSource = DataRepository.Code.GetAllReports();
        }
        public BookReportForm(int bookId) : this()
        {
            _bookId = bookId;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cbbReportCode.SelectedValue == null)
                return;
            Report report = new Report();

            report.BookId = _bookId;
            report.ReportCodeId = cbbReportCode.SelectedValue.ToString();

            DataRepository.Report.Insert(report);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}