using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class BookData : EntityData<Book>
    {
        public Book Get(int bookId)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.BookId == bookId);
        }

        public Book GetbyISBN(string isbn)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.ISBN == isbn);
        }

        public Book GetName(string name)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.Name == name);
        }
    }
}
