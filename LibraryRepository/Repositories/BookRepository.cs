using LibraryRepository.Database;
using LibraryRepository.Models;
using MongoDB.Bson;
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
        public static Book GetBookById(ObjectId bookId)
        {
            BookHandlers bh = new BookHandlers();
            return bh.GetBookByIdFromDB(bookId);
        }
        public static void DeleteBook(ObjectId bookId)
        {
            BookHandlers bh = new BookHandlers();
            bh.DeleteBookById(bookId);
        }
        public static void SaveBookToDB(Book book)
        {
            BookHandlers bh = new BookHandlers();
            bh.SaveBookToDB(book);
        }
        public static void UpdateBook(ObjectId bookToUpdateId, Book updatedBook)
        {
            BookHandlers bh = new BookHandlers();
            bh.UpdateBook(bookToUpdateId, updatedBook);
        }
    }
}
