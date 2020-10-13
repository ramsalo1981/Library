using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace MVC_LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<Book> books = BookRepository.GetBooks();
            return View(books);
        }

        public IActionResult Details(string id)
        {
            ObjectId bookId = new ObjectId(id);
            Book book = BookRepository.GetBookById(bookId);

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, int releseYear, string genre, int numberOfCopies, string author, int pages)
        {
            BookRepository.SaveBookToDB(new Book
            {
                Name = name,
                ReleseYear = releseYear,
                Genre = genre,
                NumberOfCopies = numberOfCopies,
                Author = author,
                Pages = pages
            });

            return Redirect("/Book");
        }

        public IActionResult Edit(string id)
        {
            ObjectId bookId = new ObjectId(id);
            Book book = BookRepository.GetBookById(bookId);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(string id, string name, int releseYear, string genre, int numberOfCopies, string author, int pages)
        {
            ObjectId bookId = new ObjectId(id);
            Book updatedBook = new Book(name, releseYear, genre, numberOfCopies, author, pages);
            BookRepository.UpdateBook(bookId,updatedBook);
            return Redirect("/Book");
        }

        public IActionResult Delete(string id)
        {
            ObjectId bookId = new ObjectId(id);
            Book book = BookRepository.GetBookById(bookId);

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(string id)
        {
            ObjectId bookId = new ObjectId(id);
            BookRepository.DeleteBook(bookId);
            return Redirect("/Book");
        }
    }
}