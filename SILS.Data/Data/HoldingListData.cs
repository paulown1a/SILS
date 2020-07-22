using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class HoldingListData : EntityData<HoldingList>
    {
        public HoldingList Get(string libraryId, int bookId)
        {
            SILSEntities context = CreateContext();
            return context.HoldingLists.FirstOrDefault(a => a.BookId == bookId && a.LibraryId == libraryId);
        }
    }
}
