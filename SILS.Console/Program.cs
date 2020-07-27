using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using ExcelDataReader;
using Newtonsoft.Json;
using SILS.Data;

namespace SILS.Console
{
    class Program
    {
        public static string[] targetLibraries = { "강남도서관", "강동도서관", "강서도서관", "개포도서관", "고척도서관", "구로도서관", "남산도서관", "도봉도서관", "동대문도서관", "동작도서관", "서대문도서관", "송파도서관", "양천도서관", "용산도서관", "정독도서관", "종로도서관", "서울시립어린이도서관" };


        static void Main(string[] args)
        {
            int target = 0;
            using (var stream = File.Open($@"C:\\git\\SILS\\BookData\\{targetLibraries[target]} 장서 대출목록 (2020년 06월).xlsx", FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    int i = 196061;
                    while (true)
                    {
                        Book book = new Book();
                        book.Name = result.Tables[0].Rows[i][1].ToString();
                        book.Author = result.Tables[0].Rows[i][2].ToString().Replace(";","")==""? "=": result.Tables[0].Rows[i][2].ToString().Replace(";", "");
                        book.Publisher = result.Tables[0].Rows[i][3].ToString() == "" ? "=" : result.Tables[0].Rows[i][3].ToString();
                        book.PublicationYear = result.Tables[0].Rows[i][4].ToString();
                        book.ISBN = result.Tables[0].Rows[i][5].ToString();
                        try
                        {
                            book.KDCId = 'K'+ result.Tables[0].Rows[i][9].ToString().Substring(0,3) ;
                        }
                        catch
                        {
                            book.KDCId = "K1000";
                        }
      
                        //Console.WriteLine(result.Tables[0].Columns.Count);
                        
                      
                        if (DataRepository.Book.GetbyISBN(book.ISBN) == null || 
                            DataRepository.Book.GetName(book.Name)==null)
                        {
                            DataRepository.Book.Insert(book);
                            System.Console.WriteLine($"{i} / {book.Name} / {book.Author} / {book.Publisher}");
                        }
                            
                        

                        HoldingList holdingList = new HoldingList();
                        holdingList.LibraryId = DataRepository.Library.GetName(targetLibraries[target]).LibraryId;
                        holdingList.BookId = DataRepository.Book.GetbyISBN(book.ISBN).BookId;
                        holdingList.Count = int.Parse(result.Tables[0].Rows[i][10].ToString());
                        holdingList.ReceiptDate = result.Tables[0].Rows[i][12].ToString();
                        holdingList.Classification = book.KDCId == "K1000" ? true : false;
                        if (DataRepository.HoldingList.Get(holdingList.LibraryId, holdingList.BookId) == null)
                            DataRepository.HoldingList.Insert(holdingList);
                        // The result of each spreadsheet is in result.Tables
                        i++;
                        if (result.Tables[0].Rows[i][0] == null)
                           
                            break;
                    }

                }

                    #region
                    /*int select = 0;
                        System.Console.WriteLine("원하는 기능을 선택하세요.\n도서관 최신화 => 1\t 종료=> 다른키");

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
                        }*/
                    #endregion
                
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

        private static List<Book> LoadBooks(string targetLibraries)
        {
            var lines = File.ReadAllLines($@"C:\git\SILS\SILS.Console\LibraryBooksData\{targetLibraries} 장서 대출목록 (2020년 06월).csv", System.Text.Encoding.Default).Skip(1);

            List<Book> books = new List<Book>(lines.Count());
            foreach (var line in lines)
            {
                Book book = new Book();
                var tokens = line.Replace("\"", "").Split(',');

                if (tokens[5] != "")
                {
                    book.Name = tokens[1];
                    book.Author = tokens[2];
                    try
                    {
                        book.Publisher = tokens[3];
                    }
                    catch
                    {
                        book.Publisher = "-";
                    }
                    book.PublicationYear = tokens[4] == "" ? "-" : tokens[4];
                    book.ISBN = tokens[5];
                    //book.Count = int.Parse(tokens[10]);
                  //  book.ReceiptDate = DateTime.Parse(tokens[12]);
                    try
                    {
                        book.KDCId = "K" + tokens[9].Substring(0, 3);
                    }
                    catch
                    {
                        book.KDCId = "K1000";
                    }
                    books.Add(book);
                }
            }
            return books;
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
