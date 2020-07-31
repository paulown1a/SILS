using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.API
{
    public class BookAPI
    {
        public string BookName { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }
        public string Isbn13 { get; set; }
        public string BookImageUrl { get; set; }
        public string AdditionSymbol { get; set; }
        public string Vol { get; set; }
        public string ClassNo { get; set; }
        public string BookCount { get; set; }
        public int LoanCount { get; set; }
        public DateTime RegDate { get; set; }

        public static BookAPI Convert(dynamic value)
        {
            BookAPI book = new BookAPI();
            book.LoanCount = int.Parse(value.loan_count.ToString());
            book.RegDate = DateTime.Parse((string)value.reg_date);

            return book;
        }
    }
}
