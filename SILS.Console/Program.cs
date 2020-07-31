using System;
using System.Collections.Generic;
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
            HashSet<string> bookEntity = new HashSet<string>();
            HashSet<string> holdingListEntity = new HashSet<string>();

            List<Book> books = DataRepository.Book.GetAll();
            List<HoldingList> holdingLists = DataRepository.HoldingList.GetAll();

            foreach (Book book in books)
            {
                bookEntity.Add(book.Name + book.ISBN);
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
                for (int i = 0; i < Constant.targetLibraries.Length; i++)
                {
                    if (library.Name == Constant.targetLibraries[i])
                    {
                        System.Console.WriteLine($"{library.LocationId[0]} / {library.LocationId[1]} / {library.Name}"); // Insert 확인용

                        DataRepository.Library.InsertAPI(library);

                    }
                }
            #endregion


            for (int target = 11; target >= 0; target--)
            {
                using (var stream = File.Open($@"C:\\git\\SILS\\BookData\\{Constant.targetLibraries[target]} 장서 대출목록 (2020년 06월).xlsx", FileMode.Open, FileAccess.Read))
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

                        
                        int i = 1;
                        while (true)
                        {
                            Book book = new Book();
                            book.Name = result.Tables[0].Rows[i][1].ToString();
                            book.Author = result.Tables[0].Rows[i][2].ToString().Replace(";", "") == "" ? "=" : result.Tables[0].Rows[i][2].ToString().Replace(";", "");
                            book.Publisher = result.Tables[0].Rows[i][3].ToString() == "" ? "=" : result.Tables[0].Rows[i][3].ToString();
                            book.PublicationYear = result.Tables[0].Rows[i][4].ToString();
                            book.ISBN = result.Tables[0].Rows[i][5].ToString();
                            try
                            {
                                book.KDCId = 'K' + result.Tables[0].Rows[i][9].ToString().Substring(0, 3);
                            }
                            catch
                            {
                                book.KDCId = "K1000";
                            }
                            string nameWithISBN = book.Name + book.ISBN;

                            if (!bookEntity.Contains(nameWithISBN))
                            {
                                bookEntity.Add(nameWithISBN);

                                System.Console.WriteLine($"책 들어간다{target} : {i} / {book.Name} / {book.Author} / {book.Publisher}"); // Insert 확인용
                                DataRepository.Book.Insert(book);
                            }

                            HoldingList holdingList = new HoldingList();
                            holdingList.LibraryId = DataRepository.Library.GetName(Constant.targetLibraries[target]).LibraryId;
                            holdingList.BookId = DataRepository.Book.GetbyISBN(book.ISBN).BookId;
                            holdingList.Count = int.Parse(result.Tables[0].Rows[i][10].ToString());
                            holdingList.ReceiptDate = result.Tables[0].Rows[i][12].ToString();
                            holdingList.Classification = book.KDCId == "K1000" ? true : false;

                            //------------------------------------------
                            string bookidWithLibraryid = holdingList.LibraryId + holdingList.BookId.ToString();
                            if (!holdingListEntity.Contains(bookidWithLibraryid))
                            {
                                holdingListEntity.Add(bookidWithLibraryid);
                                System.Console.WriteLine($"홀딩리스트{target} : {i} / {holdingList.BookId} /         {holdingList.LibraryId}");
                                DataRepository.HoldingList.Insert(holdingList);
                            }

                            //레거시 코드(Too many query requested)

                            /*if (DataRepository.HoldingList.Get(holdingList.LibraryId, holdingList.BookId) == null)
                            {
                                DataRepository.HoldingList.Insert(holdingList);
                                System.Console.WriteLine($"{i} / {book.Name} / {book.KDCId} / {holdingList.Library}");
                            }*/

                            // The result of each spreadsheet is in result.Tables
                            i++;
                            try
                            {
                                if (result.Tables[0].Rows[i][0] == null)
                                {
                                    System.Console.WriteLine("\n끝");
                                    break;
                                }
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                System.Console.WriteLine("\n끝");
                                break;
                            }
                        }
                    }
                }
               

                /*int select = 0;
                System.Console.WriteLine("원하는 기능을 선택하세요.\n도서관 최신화 => 1\t 종료=> 다른키");

                select = int.Parse(System.Console.ReadLine());
                if (select == 1)
                {
                    
                }*/
                //도서관 최신화 console (구현 중)


            }

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