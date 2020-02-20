using LibraryRepository.Models;
using LibraryRepository.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class PrintListsFromDB
    {
        /// <summary>
        /// prints all books in the datebase
        /// </summary>
        public static void PrintBooksList()
        {
            List<Book> books = BookRepository.GetBooks();

            StandardMessages.ListAllItems("books");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Name} {book.ReleseYear} {book.Genre} {book.Author} {book.Pages}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// prints all movies in the database
        /// </summary>
        public static void PrintMoviesList()
        {
            List<Movie> movies = MovieRepository.GetMovies();

            StandardMessages.ListAllItems("movies");
            foreach (Movie movie in movies)
            {
                TimeSpan t = TimeSpan.FromMinutes(movie.Duration);
                string duration = string.Format("{0:D2}h:{1:D2}m", t.Hours, t.Minutes);

                Console.WriteLine($"{movie.Name} {movie.ReleseYear} {movie.Genre} {duration} {movie.AgeLimit}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Prints all book loans with the id of the book the user wanted to borrow
        /// </summary>
        /// <param name="id">book id of the wanted book</param>
        public static void PrintBookLoansList(ObjectId id)
        {
            List<Loan> loans = BookLoanRepository.GetBookLoansById(id);

            StandardMessages.ListAllItems("loans");
            DateTime today = DateTime.Today;

            foreach (Loan loan in loans)
            {
                int result = Validations.CompareDates(today, loan.EndDate);
                if (result < 0)
                {
                    var startDate = loan.StartDate.ToString("yyyy-MM-dd");
                    var endDate = loan.EndDate.ToString("yyyy-MM-dd");

                    Console.WriteLine($"{loan.BookArticle.Name} - {loan.Member.Name} - {startDate} - {endDate}");
                }
            }
        }

        /// <summary>
        /// Prints all movie loans with the id of the movie the user wanted to borrow
        /// </summary>
        /// <param name="id">movie id of the wanted book</param>
        public static void PrintMovieLoansList(ObjectId id)
        {
            List<Loan> loans = MovieLoanRepository.GetMovieLoansById(id);

            StandardMessages.ListAllItems("loans");
            DateTime today = DateTime.Today;

            foreach (Loan loan in loans)
            {
                int result = Validations.CompareDates(today, loan.EndDate);
                if (result < 0)
                {
                    var startDate = loan.StartDate.ToString("yyyy-MM-dd");
                    var endDate = loan.EndDate.ToString("yyyy-MM-dd");
                    Console.WriteLine($"{loan.MovieArticle.Name} - {loan.Member.Name} - {startDate} - {endDate}");
                }
            }

        }
    }
}
