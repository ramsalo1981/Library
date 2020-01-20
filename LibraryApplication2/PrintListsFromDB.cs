using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class PrintListsFromDB
    {
        public static void PrintBookLoansList(ObjectId id)
        {
            Database.LoanHandlers lh = new Database.LoanHandlers();
            List<Loan> loans = lh.GetBookLoansById(id);

            StandardMessages.ListAllItems("loans");

            foreach (Loan loan in loans)
            {
                var startDate = loan.StartDate.ToString("yyyy-MM-dd");
                var endDate = loan.EndDate.ToString("yyyy-MM-dd");
                
                Console.WriteLine($"{loan.BookArticle.Name} - {loan.Member.Name} - {startDate} - {endDate}");
            }
        }
        public static void PrintMovieLoansList(ObjectId id)
        {
            Database.LoanHandlers lh = new Database.LoanHandlers();
            List<Loan> loans = lh.GetMovieLoansById(id);

            StandardMessages.ListAllItems("loans");

            foreach (Loan loan in loans)
            {
                var startDate = loan.StartDate.ToString("yyyy-MM-dd");
                var endDate = loan.EndDate.ToString("yyyy-MM-dd");
                Console.WriteLine($"{loan.MovieArticle.Name} - {loan.Member.Name} - {startDate} - {endDate}");
            }
            
        }
        public static void PrintBooksList()
        {
            Database.BookHandlers bh = new Database.BookHandlers();
            List<Book> books = bh.GetBooksFromDB();

            StandardMessages.ListAllItems("books");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Id} {book.Type} {book.Name} {book.ReleseYear} {book.Genre} {book.Author} {book.Pages}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
        public static void PrintMoviesList()
        {
            Database.MovieHandlers mh = new Database.MovieHandlers();
            List<Movie> movies = mh.GetMoviesFromDB();

            StandardMessages.ListAllItems("movies");
            foreach (Movie movie in movies)
            {
                TimeSpan t = TimeSpan.FromMinutes(movie.Duration);
                string duration = string.Format("{0:D2}h:{1:D2}m", t.Hours, t.Minutes);

                Console.WriteLine($"{movie.Id} {movie.Name} {movie.ReleseYear} {movie.Genre} {duration} {movie.AgeLimit}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
        public static void PrintMembersList()
        {
            Database.MemberHandlers mh = new Database.MemberHandlers();
            List<Member> members = mh.GetMembersFromDB();

            StandardMessages.ListAllItems("members");
            foreach (Member member in members)
            {
                Console.WriteLine($"{member.Id} {member.Name} {member.Age}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
       
    }
}
