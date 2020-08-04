using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Report> GetByReportType(string codeId)
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
        }

        public List<Report> GetByTypeNId(string codeId, string libraryId)
        {
            SILSEntities context = CreateContext();
            var Idquery = from x in context.HoldingLists 
                          where x.LibraryId == libraryId
                          select x.Book;
            List<Book> bookqueries = Idquery.ToList();

            List<Report> reports = new List<Report>();
            foreach (Book book in bookqueries)
            {
                var query = from y in context.Reports
                            where y.BookId == book.BookId && y.ReportCodeId==codeId
                            select new { Report = y, BookName = y.Book.Name, CodeName = y.Code.Name };
                var items = query.ToList();
                foreach (var item in items)
                {
                    item.Report.BookName = item.BookName;
                    item.Report.ReportCodeName = item.CodeName;
                }

                reports.AddRange(items.ConvertAll(y => y.Report));
            }


            return reports;
        }

        public List<Report> GetByLibraryId(string libraryId)
        {
            SILSEntities context = CreateContext();
            var Idquery = from x in context.HoldingLists
                        where x.LibraryId == libraryId && x.Book.Reports.Any(r => r.BookId == x.BookId)
                        select x.Book.Reports;

            var reports = Idquery.SelectMany(x => x).ToList();

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
            return reports;
        }
    }
}
