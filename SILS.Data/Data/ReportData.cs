using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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

        /*public List<Report> GetByReportType(string codeId)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Reports
                        where x.ReportCodeId == codeId
                        select new { Report = x, BookName = x.Book.Name, CodeName = x.Code.Name };
            var items = query.ToList();

            foreach (var item in items)
            {
                item.Report.BookName = item.BookName;
                item.Report.ReportCodeName = item.CodeName;
            }
            return items.ConvertAll(x => x.Report);
        }

        public List<Report> GetWithReported()
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Reports
                        select new { Report=x, BookName=x.Book.Name, CodeName=x.Code.Name};
            var items = query.ToList();

            foreach(var item in items)
            {
                item.Report.BookName = item.BookName;
                item.Report.ReportCodeName = item.CodeName;
            }
            return items.ConvertAll(x=>x.Report);
        }*/

       

        public List<Report> GetByLibraryNType(string libraryId, string reportCodeId)
        {
            SILSEntities context = CreateContext();

            //var bookIdsInReport = context.Reports.Select(x => x.BookId).ToList();

            var query = from x in context.HoldingLists
                        //where x.Book.Reports.Any(r => r.BookId == x.BookId)
                        //where bookIdsInReport.Contains(x.BookId)
                        select x;

            if (string.IsNullOrEmpty(libraryId) == false)
                query = query.Where(x => x.LibraryId == libraryId);

            if (string.IsNullOrEmpty(reportCodeId) == false)
                query = query.Where(x => x.Book.Reports.Any(r => r.ReportCodeId == reportCodeId));

            var query2 = from x in query.SelectMany(x => x.Book.Reports)
                        select new { Report = x, BookName = x.Book.Name, CodeName = x.Code.Name };

            var items = query2.ToList();
            foreach (var item in items)
            {
                item.Report.BookName = item.BookName;
                item.Report.ReportCodeName = item.CodeName;
            }

            return items.ConvertAll(x => x.Report);
            //List<Book> bookqueries = Idquery.ToList();

            //List<Report> reports = new List<Report>();
            //foreach (Book book in bookqueries)
            //{
            //    var query = from y in context.Reports
            //                where y.BookId == book.BookId
            //                select new { Report = y, BookName = y.Book.Name, CodeName = y.Code.Name };
            //    var items = query.ToList();
            //    foreach (var item in items)
            //    {
            //        item.Report.BookName = item.BookName;
            //        item.Report.ReportCodeName = item.CodeName;
            //    }

            //    reports.AddRange(items.ConvertAll(y => y.Report));
            //}
        }
    }
}
