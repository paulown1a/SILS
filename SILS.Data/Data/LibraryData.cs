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
    }
}
