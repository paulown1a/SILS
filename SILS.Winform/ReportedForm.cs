using SILS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILS.Winform
{
    public partial class ReportedForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportedForm()
        {
            InitializeComponent();
            bdsLibraryReported.DataSource = DataRepository.Library.GetAll();
            bdsCodeReported.DataSource = DataRepository.Code.GetAllReports();
            bdsReport.DataSource = DataRepository.Report.GetWithReported();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbLibrary.Checked == false && cbReport.Checked == false)
                bdsReport.DataSource = DataRepository.Report.GetWithReported();

            else if(cbLibrary.Checked == false && cbReport.Checked != false)
                bdsReport.DataSource = DataRepository.Report.GetByReportType(cbbReportType.SelectedValue.ToString());

            else if (cbLibrary.Checked != false && cbReport.Checked == false)
                bdsReport.DataSource = DataRepository.Report.GetByLibraryId(cbbLibrary.SelectedValue.ToString());

            else
                bdsReport.DataSource = DataRepository.Report.GetByTypeNId(
                    cbbReportType.SelectedValue.ToString(),
                    cbbLibrary.SelectedValue.ToString()
                    );

        }
    }
}
