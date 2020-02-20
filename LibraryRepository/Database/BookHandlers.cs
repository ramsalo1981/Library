using LibraryRepository.Models;
using MongoDB.Bson;
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
        public BookHandlers(string dbName = "mvc-library-application")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }
        public void SaveBookToDB(Book book)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            collection.InsertOne(book);
        }

        internal Book GetBookByIdFromDB(ObjectId bookId)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            return collection.Find(b => b.Id == bookId).First();
        }

        public void DeleteBookById(ObjectId bookId)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            collection.DeleteOne(b => b.Id == bookId);
        }

        public List<Book> GetBooksFromDB()
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            var books = collection.Find<Book>(b => true).ToList();
            return books;
        }
        public void UpdateBook(ObjectId bookToUpdateId, Book updatedBook)
        {
            var collection = _database.GetCollection<Book>(BOOKS_COLLECTION);
            UpdateDefinition<Book> update = Builders<Book>.Update
                .Set(b => b.Name, updatedBook.Name)
                .Set(b => b.ReleseYear, updatedBook.ReleseYear)
                .Set(b => b.Genre, updatedBook.Genre)
                .Set(b => b.Author, updatedBook.Author)
                .Set(b => b.Pages, updatedBook.Pages);
            collection.UpdateOne(b => b.Id == bookToUpdateId, update);
        }
    }
}
