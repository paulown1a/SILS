using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class HoldingStatuData : EntityData<HoldingStatu>
    {
        public HoldingStatu Get(string libraryId, int bookId)
        {
            SILSEntities context = CreateContext();
            return context.HoldingStatus.FirstOrDefault(a => a.LibraryId == libraryId && a.BookId == bookId);
        }
    }
}
