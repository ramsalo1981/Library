using LibraryRepository.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class BookHandlers
    {
        private const string BOOKS_COLLECTION = "books";
        private readonly IMongoDatabase _database;
        public BookHandlers(string dbName = "library-application2")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }
        public void SaveBookToDB(Book book)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            collection.InsertOne(book);
        }

        public void DeleteBookById(Book book)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            collection.DeleteOne(b => b.Id == book.Id);
        }

        public List<Book> GetBooksFromDB()
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            var books = collection.Find<Book>(b => true).ToList();
            return books;
        }
        public void UpdateBook(Book bookToUpdate, Book updatedBook)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            UpdateDefinition<Book> update = Builders<Book>.Update
                .Set(b => b.Name, updatedBook.Name)
                .Set(b => b.ReleseYear, updatedBook.ReleseYear)
                .Set(b => b.Genre, updatedBook.Genre)
                .Set(b => b.Author, updatedBook.Author)
                .Set(b => b.Pages, updatedBook.Pages);
            collection.UpdateOne(b => b.Id == bookToUpdate.Id, update);
        }
    }
}
