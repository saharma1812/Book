using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookRepository : IBookRepository
    {
        private MyCmsContext db;
        public BookRepository(MyCmsContext context)
        {
            this.db = context;
        }


        public IEnumerable<Book> GetAllBooks()
        {
            return db.Books;
        }

        public Book GetBookById(int bookId)
        {
            return db.Books.Find(bookId);
        }

        public bool InsertBook(Book book)
        {
            try
            {
                db.Books.Add(book);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool UpdateBook(Book book)
        {
            try
            {
                db.Entry(book).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteBook(Book book)
        {
            try
            {
                db.Entry(book).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteBook(int bookId)
        {
            try
            {
                var book = GetBookById(bookId);
                DeleteBook(book);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void save()
        {
            db.SaveChanges();
        }
    }
}
