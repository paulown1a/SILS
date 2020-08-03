using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using ExcelDataReader;
using Newtonsoft.Json;
using SILS.API;
using SILS.Data;

namespace SILS.Console
{
    class Program
    {
        //코드 변경
        static void Main(string[] args)
        {

            #region// HashSet
            HashSet<string> bookSet = new HashSet<string>();
            HashSet<string> holdingListEntity = new HashSet<string>();

            List<Book> books = DataRepository.Book.GetAll();
            List<HoldingList> holdingLists = DataRepository.HoldingList.GetAll();

            foreach (Book book in books)
            {
                bookSet.Add(book.Name + book.ISBN);
            }

            foreach (HoldingList holdingList in holdingLists)
            {
                holdingListEntity.Add(holdingList.LibraryId + holdingList.BookId.ToString());
            }
            #endregion

            #region//도서관DB입력
            List<LibraryAPI> libraries = new List<LibraryAPI>(1100);
            for (int i = 1; i <= 3; i++)
            {
                libraries.AddRange(LibraryAPI.Instance.LoadLibraries(i));
            }
            foreach (var library in libraries)
                for (int i = 0; i < Constant.TargetLibraries.Length; i++)
                {
                    if (library.Name == Constant.TargetLibraries[i])
                    {
                        System.Console.WriteLine($"{library.LocationId[0]} / {library.LocationId[1]} / {library.Name}"); // Insert 확인용

                        DataRepository.Library.InsertAPI(library);

                    }
                }
            #endregion

            #region//책,홀딩리스트 입력
            for (int target = 16; target >= 0; target--)
            {
                using (var stream = File.Open($@"BookData\{Constant.TargetLibraries[target]} 장서 대출목록 (2020년 06월).xlsx", FileMode.Open, FileAccess.Read))
                {
                    // Auto-detect format, supports:
                    //  - Binary Excel files (2.0-2003 format; *.xls)
                    //  - OpenXml Excel files (2007 format; *.xlsx)
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Choose one of either 1 or 2:
                        reader.Read();
                        while (reader.Read())
                        {
                            Book book = ReadBook(reader);

                            string nameWithISBN = book.Name + book.ISBN;

                            if (!bookSet.Contains(nameWithISBN))
                            {
                                bookSet.Add(nameWithISBN);

                                Debug.WriteLine($"책 들어간다{target} : {reader.GetInt32(0)} / {book.Name} / {book.Author} / {book.Publisher}"); // Insert 확인용
                                DataRepository.Book.Insert(book);
                            }

                            HoldingList holdingList = ReadHoldingList(reader,book,target);

                            string bookidWithLibraryid = holdingList.LibraryId + holdingList.BookId.ToString();

                            if (!holdingListEntity.Contains(bookidWithLibraryid))
                            {
                                holdingListEntity.Add(bookidWithLibraryid);
                                Debug.WriteLine($" 홀딩리스트{target} : {reader.GetInt32(0)} / {holdingList.BookId} /         {holdingList.LibraryId}");
                                DataRepository.HoldingList.Insert(holdingList);
                            }

                        }

                        Debug.WriteLine("\n끝");
                    }
                }
            }
            #endregion
        }

        private static Book ReadBook(IExcelDataReader reader)
        {
            Book book = new Book();
            
            book.Name = reader.GetString(1);
            book.Author = reader.GetString(2).CleanNULL();
            book.Publisher = reader.GetString(3).CleanNULL();
            book.PublicationYear = reader.GetString(4).CleanNULL();
            book.ISBN = reader.GetString(5);
            try
            {
                book.KDCId = 'K' + reader.GetString(9).Substring(0, 3);
            }
            catch
            {
                book.KDCId = "K1000";
            }
            
            return book;
        }


        private static HoldingList ReadHoldingList(IExcelDataReader reader, Book book, int target)
        {
            HoldingList holdingList = new HoldingList();

            holdingList.LibraryId = DataRepository.Library.GetName(Constant.TargetLibraries[target]).LibraryId;
            holdingList.BookId = DataRepository.Book.GetbyISBN(book.ISBN).BookId;
            holdingList.Count = reader.GetInt32(10);
            holdingList.ReceiptDate = reader.GetString(12).CleanNULL();
            holdingList.Classification = book.KDCId == "K1000" ? true : false;
            
            return holdingList;
        }
        #region // CSV Legacy Code  마크다운용


        /*private static List<Book> LoadBooks(string targetLibraries)
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
        }*/
        #endregion
    }
}