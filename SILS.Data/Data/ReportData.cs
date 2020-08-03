using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class ReportData : EntityData<Report>
    {
        public Report Get(int reportId)
        {
            SILSEntities context = CreateContext();
            return context.Reports.FirstOrDefault(a => a.ReportId == reportId);
        }

        
    }
}
