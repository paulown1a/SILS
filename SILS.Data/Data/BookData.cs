using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class BookData : EntityData<Book>
    {
        public Book Get(int bookId)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.BookId == bookId);
        }

        public Book GetbyISBN(string isbn)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.ISBN == isbn);
        }

        public Book GetName(string name)
        {
            SILSEntities context = CreateContext();
            return context.Books.FirstOrDefault(a => a.Name == name);
        }

        public Task<List<Book>> GetAllNameAsync(string name)
        {
            return Task.Factory.StartNew(() => DataRepository.Book.GetAllName(name));
        }

        
        /*public List<Book> GetAllName(string name)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Books
                        where x.Name.Contains(name)
                        select x;
            return query.ToList();
        }*/
        
        
        public List<Book> GetAllName(string name, string publisher = null, string author = null, string publishedYear = null)
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Books
                        where x.Name.Contains(name)
                        select x;
            List<Book> allBooks = query.ToList();
            List<Book> books = new List<Book>();
            if (publisher != null)
            {
                foreach (var book in allBooks)
                    if (book.Publisher.Contains(publisher))
                        books.Add(book);
                allBooks = books;
                books = new List<Book>();
            }
            if (author != null)
            {
                foreach (var book in allBooks)
                    if (book.Author.Contains(author))
                        books.Add(book);
                allBooks = books;
                books = new List<Book>();
            }
            if (publishedYear != null)
            {
                foreach (var book in allBooks)
                    if (book.PublicationYear.Contains(publishedYear))
                        books.Add(book);
                allBooks = books;
            }

            return allBooks;
        }
    }
}
