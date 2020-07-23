using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using SILS.Data;

namespace SILS.Console
{
    class Program
    {
        public static string[] targetLibraries ={ "강남도서관","강동도서관","강서도서관","개포도서관","고척도서관","구로도서관","남산도서관","도봉도서관","동대문도서관","동작도서관","서대문도서관","송파도서관","양천도서관","용산도서관","정독도서관","종로도서관","서울시립어린이도서관" };
        static void Main(string[] args)
        {
            int select = 0;
            System.Console.WriteLine("원하는 기능을 선택하세요.\n도서관 최신화 - 1");

            select = int.Parse(System.Console.ReadLine());
            if (select == 1)
            {
                List<APILibrary> libraries = new List<APILibrary>(1100);
                for (int i = 1; i <= 3; i++)
                {
                    libraries.AddRange(LoadLibraries(i));
                }
                foreach (var library in libraries)
                    for (int i = 0; i < targetLibraries.Length; i++)
                    {
                        if (library.Name == targetLibraries[i])
                        {
                            System.Console.WriteLine($"{library.LocationId[0]} / {library.LocationId[1]} / {library.Name}");
                            Library insertLibrary = new Library();
                            Code code = DataRepository.Code.GetByNameAndUpper(library.LocationId[0]);
                            insertLibrary.LocationId = DataRepository.Code.GetByNameAndUpper(library.LocationId[1], code.CodeId).CodeId;
                            insertLibrary.LibraryId = library.LibraryId;
                            insertLibrary.Name = library.Name;
                            insertLibrary.Adress = library.Address;
                            insertLibrary.Website = library.Website;
                            insertLibrary.PhoneNumber = library.PhoneNumber;
                            DataRepository.Library.Insert(insertLibrary);
                        }
                    }
            }
        }


        private static List<APILibrary> LoadLibraries(int pageNumber)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            var json = web.DownloadString($"http://data4library.kr/api/libSrch?authKey=3cacb648eebbd3eb2f908f4b499e3b2914fed0669f4b263f7378fe45edb26a7d&pageNo={pageNumber}&pageSize=500&format=json");

            dynamic content = JsonConvert.DeserializeObject<dynamic>(json);

            List<APILibrary> libraries = new List<APILibrary>(int.Parse(content.response.request.pageSize.ToString()));

            foreach (dynamic item in content.response.libs)
            {
                dynamic lib = item.lib;
                APILibrary library = APILibrary.Convert(lib);
                if (library != null)
                    libraries.Add(library);
            }

            return libraries;
        }
    }

    public class APILibrary
    { 
        public string LibraryId { get; set; }
        public string Name { get; set; }
        public string[] LocationId { get; set; } = new string[2];
        public string Address { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public static APILibrary Convert(dynamic value)
        {
            APILibrary library = new APILibrary();
            if (value.libCode == null)
                return null;
            library.LibraryId = value.libCode.ToString();
            library.Name = value.libName.ToString();
            library.Address = value.address.ToString();
            library.Website = value.homepage==null?null: value.homepage.ToString();
            library.PhoneNumber = value.tel == null ? null : value.tel.ToString();
            string address = value.address.ToString();
            string[] token = address.Split(' ');
            library.LocationId[0] = token[0].Substring(0,2);
            library.LocationId[1] = token[1];
            return library;
        }
    }

    public class APIBook
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

        public static APIBook Convert(dynamic value)
        {
            APIBook book = new  APIBook();
            book.LoanCount = int.Parse(value.loan_count.ToString());
            book.RegDate = DateTime.Parse((string)value.reg_date);

            return book;
        }
    }
}
