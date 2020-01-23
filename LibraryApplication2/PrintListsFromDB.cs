using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    public class PrintListsFromDB
    {
        public static void PrintBookLoansList(ObjectId id)
        {
            List<Loan> loans = LoanRepository.GetBookLoansById(id);

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
        public static void PrintMovieLoansList(ObjectId id)
        {
            List<Loan> loans = LoanRepository.GetMovieLoansById(id);

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
        public static void PrintBooksList()
        {
            List<Book> books = BookRepository.GetBooks();

            StandardMessages.ListAllItems("books");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Type} {book.Name} {book.ReleseYear} {book.Genre} {book.Author} {book.Pages}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
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
        public static void PrintMembersList()
        {
            List<Member> members = MemberRepository.GetMembers();

            StandardMessages.ListAllItems("members");
            foreach (Member member in members)
            {
                Console.WriteLine($"{member.Name} {member.Age}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
       
    }
}
