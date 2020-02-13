using LibraryRepository.Factory;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    class LoanDataCapture
    {
        /// <summary>
        /// Sets the startDate to date which is DateTime.Today; and adds 3 months to get the endDate
        /// then adds those dates along with the book article and member to a new loan
        /// </summary>
        /// <param name="member">Member to borrow the book</param>
        /// <param name="book">the book to borrow</param>
        /// <param name="date">the date the loan starts</param>
        /// <returns>a loan object</returns>
        internal static Loan LoanBook(Member member, Book book, DateTime date)
        {
            DateTime startDate = date;
            DateTime endDate = date.AddMonths(1);
            Loan loan = Factory.CreateLoan(startDate, endDate, member);
            loan.BookArticle = book;

            return loan;
        }

        /// <summary>
        /// the user gets to select a new date to borrow a book
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns>a valid DateTime</returns>
        internal static DateTime SelectNewDateBook(ObjectId id)
        {
            PrintListsFromDB.PrintBookLoansList(id);
            Console.WriteLine("\nWhen do you want to borrow the book, enter 0 to Exit? (yyyy-mm-dd): ");
            string input = Console.ReadLine();

            DateTime date = Validations.Date(input);
            return date;
        }

        /// <summary>
        /// Sets the startDate to date which is DateTime.Today; and adds 3 months to get the endDate
        /// then adds those dates along with the movie article and member to a new loan
        /// </summary>
        /// <param name="member">Member to borrow the movie</param>
        /// <param name="movie">the movie to borrow</param>
        /// <param name="date">the date the loan starts</param>
        /// <returns>a loan object</returns>
        internal static Loan LoanMovie(Member member, Movie movie, DateTime date)
        {
            DateTime startDate = date;
            DateTime endDate = date.AddMonths(1);

            Loan loan = Factory.CreateLoan(startDate, endDate, member);
            loan.MovieArticle = movie;
            return loan;
        }

        /// <summary>
        /// the user gets to select a new date to borrow a movie
        /// </summary>
        /// <param name="id">movie id</param>
        /// <returns>a valid DateTime</returns>
        internal static DateTime SelectNewDateMovie(ObjectId id)
        {
            PrintListsFromDB.PrintMovieLoansList(id);
            Console.WriteLine("\nWhen do you want to borrow the movie? (yyyy-mm-dd): ");
            string input = Console.ReadLine();
            DateTime date = Validations.Date(input);

            return date;
        }
    }
}
