using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonClasses;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MVC_LibraryApplication.ViewModels;

namespace MVC_LibraryApplication.Controllers
{
    public class BookLoanController : Controller
    {
        public IActionResult Index()
        {
            List<Loan> loans = BookLoanRepository.GetAllBookLoans();
            return View(loans);
        }

        public IActionResult Create()
        {
            BookLoanModel bookLoanModel = CreateBookLoanModel();
            return View(bookLoanModel);
        }

        [HttpPost]
        public IActionResult Create(string memberId, string bookId, DateTime startDate, DateTime endDate)
        {
            ObjectId memberOId = new ObjectId(memberId);
            ObjectId bookOId = new ObjectId(bookId);

            Book book = BookRepository.GetBookById(bookOId);

            int copiesRemaining = CheckLoansToCopies.Book(book.Id, book.NumberOfCopies, startDate, endDate);
            if (copiesRemaining > 0)
            {
                Loan loan = CreateLoan(memberOId, book.Id, startDate, endDate);
                BookLoanRepository.InsertBookLoan(loan);
            }
            else if (copiesRemaining <= 0)
            {
                string errorMessage = "No availiable copies at that date. Please try an other one";
                BookLoanModel bookLoanModel = CreateBookLoanModel();
                bookLoanModel.ErrorMessage = errorMessage;
                return View(bookLoanModel);
            }

            return Redirect("/BookLoan");
        }

        public IActionResult Edit(string id)
        {
            ObjectId bookLoanId = new ObjectId(id);
            Loan loan = BookLoanRepository.GetBookLoanByBookLoanId(bookLoanId);
            return View(loan);
        }

        [HttpPost]
        public IActionResult Edit(string id, DateTime startDate, DateTime endDate)
        {
            ObjectId loanId = new ObjectId(id);
            BookLoanRepository.UpdateBookLoan(loanId, startDate, endDate);

            return Redirect("/MovieLoan");
        }

        public IActionResult Delete(string id)
        {
            ObjectId loanId = new ObjectId(id);
            BookLoanRepository.DeleteBookLoan(loanId);

            return Redirect("/MovieLoan");
        }

        public IActionResult Details(string id)
        {
            ObjectId loanId = new ObjectId(id);
            Loan loan = BookLoanRepository.GetBookLoanByBookLoanId(loanId);

            return View(loan);
        }

        private Loan CreateLoan(ObjectId memberId, ObjectId bookId, DateTime startDate, DateTime endDate)
        {
            Member member = MemberRepository.GetMemberById(memberId);

            Book book = BookRepository.GetBookById(bookId);

            Loan loan = new Loan(startDate, endDate, member);
            loan.BookArticle = book;

            return loan;
        }
        private BookLoanModel CreateBookLoanModel()
        {
            BookLoanModel bookLoanModel = new BookLoanModel();
            bookLoanModel.Members = GetMembers();
            bookLoanModel.Books = GetBooks();
            return bookLoanModel;
        }

        private List<Member> GetMembers()
        {
            List<Member> members = MemberRepository.GetMembers();
            return members;
        }

        private List<Book> GetBooks()
        {
            List<Book> books = BookRepository.GetBooks();
            return books;
        }
    }
}