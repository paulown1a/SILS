using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class DataRepository
    {
        public static CodeData Code { get; } = new CodeData();
        public static BookData Book { get; } = new BookData();
        public static LibraryData Library { get; } = new LibraryData();
        public static HoldingListData HoldingList { get; } = new HoldingListData();
    }
}
