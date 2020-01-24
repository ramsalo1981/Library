using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    class LoanDataCapture
    {
        internal static Loan LoanBook(Member member, Book book, DateTime date)
        {
            DateTime startDate = date;
            DateTime endDate = date.AddMonths(3);

            Loan loan = new Loan(startDate, endDate, member);
            loan.BookArticle = book;

            return loan;
        }

        internal static DateTime SelectNewDateBook(ObjectId id)
        {
            PrintListsFromDB.PrintBookLoansList(id);
            Console.WriteLine("\nWhen do you want to borrow the book, enter 0 to Exit? (yyyy-mm-dd): ");
            string input = Console.ReadLine();

            DateTime date = Validations.Date(input);
            return date;
        }

        internal static Loan LoanMovie(Member member, Movie movie, DateTime date)
        {
            DateTime startDate = date;
            DateTime endDate = date.AddMonths(3);

            Loan loan = new Loan(startDate, endDate, member);
            loan.MovieArticle = movie;
            return loan;
        }

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
