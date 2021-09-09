using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IBookRepository
    {

        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        bool InsertBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(Book book);
        bool DeleteBook(int bookId);
        void save();
    }
}
