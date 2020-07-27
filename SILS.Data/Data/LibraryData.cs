using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class LibraryData : EntityData<Library>
    {
        public Library Get(string libraryId)
        {
            SILSEntities context = CreateContext();
            return context.Libraries.FirstOrDefault(a => a.LibraryId == libraryId);
        }

        public Library GetName(string name)
        {
            SILSEntities context = CreateContext();
            return context.Libraries.FirstOrDefault(a => a.Name == name);
        }

        public List<Library> GetByBook(int bookId)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.HoldingLists
                        where x.BookId == bookId
                        select x.Library;
            return query.ToList();
        }
    }
}
