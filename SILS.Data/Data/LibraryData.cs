using SILS.API;
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

        public List<Library> GetByLocation(string locationId)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Libraries
                        where x.LocationId == locationId
                        select x;
            return query.ToList();
        }

        public List<Library> GetByBook(int bookId)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.HoldingLists
                        where x.BookId == bookId
                        select x.Library;
            return query.ToList();
        }

        public void InsertAPI(LibraryAPI libraryAPI)
        {
            Library library = new Library();
            Code code = DataRepository.Code.GetByNameAndUpper(libraryAPI.LocationId[0]);
            library.LocationId = DataRepository.Code.GetByNameAndUpper(libraryAPI.LocationId[1], code.CodeId).CodeId;
            library.LibraryId = libraryAPI.LibraryId;
            library.Name = libraryAPI.Name;
            library.Address = libraryAPI.Address;
            library.Website = libraryAPI.Website;
            library.PhoneNumber = libraryAPI.PhoneNumber;
            DataRepository.Library.Insert(library);
        }
    }
}
