using LibraryRepository.Database;
using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Repositories
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            BookHandlers bh = new BookHandlers();
            return bh.GetBooksFromDB();
        }
        public static void DeleteBook(Book book)
        {
            BookHandlers bh = new BookHandlers();
            bh.DeleteBookById(book);
        }

        public static void SaveBookToDB(Book book)
        {
            BookHandlers bh = new BookHandlers();
            bh.SaveBookToDB(book);
        }

        public static void UpdateBook(Book bookToUpdate, Book updatedBook)
        {
            BookHandlers bh = new BookHandlers();
            bh.UpdateBook(bookToUpdate, updatedBook);
        }
    }
}
