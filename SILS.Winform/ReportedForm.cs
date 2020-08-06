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
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsReport.DataSource = DataRepository.Report.GetByLibraryNType(cbLibrary.Checked? cbbLibrary.SelectedValue.ToString():null, cbReport.Checked? cbbReportType.SelectedValue.ToString():null).FirstOrDefault();

           /* if (cbLibrary.Checked == false && cbReport.Checked == false)
                bdsReport.DataSource = DataRepository.Report.GetWithReported();

            else if (cbLibrary.Checked == false && cbReport.Checked != false)
                bdsReport.DataSource = DataRepository.Report.GetByReportType(cbbReportType.SelectedValue.ToString());

            else if (cbLibrary.Checked != false && cbReport.Checked == false)
                //    bdsReport.DataSource = DataRepository.Report.GetByLibraryId(cbbLibrary.SelectedValue.ToString());
                ;
            else
                ;
                //    bdsReport.DataSource = DataRepository.Report.GetByTypeNId(
                //cbbReportType.SelectedValue.ToString(),
                //    cbbLibrary.SelectedValue.ToString()
                //    );
*/
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bdsLibraryReported.DataSource = DataRepository.Library.GetAll();
            bdsCodeReported.DataSource = DataRepository.Code.GetAllReports();
        }
    }
}
