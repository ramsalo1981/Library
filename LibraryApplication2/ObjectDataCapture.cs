using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LibraryApplication2
{
    class ObjectDataCapture
    {
        public static void Item(string item)
        {
            StandardMessages.CreateMessage(item);
            StandardMessages.BookOrMovieMessage();
            string itemChoice = Console.ReadLine();
            Console.Write("Name of the Item: ");
            string name = Console.ReadLine();

            Console.Write("Relese year of the Item: ");
            string input = Console.ReadLine();
            int releseYear = Validations.ParseInt(input);
            releseYear = Validations.TryAgain(releseYear);

            Console.Write("Genre of the Item: ");
            string genre = Console.ReadLine();

            Console.Write("Number of copies of the Item: ");
            input = Console.ReadLine();
            int numberOfCopies = Validations.ParseInt(input);
            numberOfCopies = Validations.TryAgain(numberOfCopies);

            if (itemChoice.ToUpper() == "B")
            {
                Book(name, "Book", releseYear, genre, numberOfCopies);
            }
            else if (itemChoice.ToUpper() == "M")
            {
                Movie(name, "Movie", releseYear, genre, numberOfCopies);
            }

        }
        public static void Book(string name, string type, int releseYear, string genre, int numberOfCopies)
        {
            Console.Write("Name of Author: ");
            string author = Console.ReadLine();

            Console.Write("Pages of the book: ");
            string input = Console.ReadLine();
            int pages = Validations.ParseInt(input);
            pages = Validations.TryAgain(pages);

            Book book = new Book(name, type, releseYear, genre, numberOfCopies, author, pages);
            Database.BookHandlers bh = new Database.BookHandlers();

            bh.SaveBookToDB(book);
            StandardMessages.WasCreatedMessage("book");
        }

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
            Console.WriteLine("\nWhen do you want to borrow the book? (yyyy-mm-dd): ");
            string input = Console.ReadLine();
            DateTime date = Convert.ToDateTime(input);

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
            DateTime date = Convert.ToDateTime(input);

            return date;
        }

        private static void Movie(string name, string type, int releseYear, string genre, int numberOfCopies)
        {
            Console.Write("Duration (minutes) of the Movie: ");
            string input = Console.ReadLine();
            int duration = Validations.ParseInt(input);
            duration = Validations.TryAgain(duration);

            Console.Write("Age limit of the Movie: ");
            input = Console.ReadLine();
            int ageLimit = Validations.ParseInt(input);
            ageLimit = Validations.TryAgain(ageLimit);

            Movie movie = new Movie(name, type, releseYear, genre, numberOfCopies, duration, ageLimit);

            Database.MovieHandlers movieHandler = new Database.MovieHandlers();
            movieHandler.SaveMovieToDB(movie);

            StandardMessages.WasCreatedMessage("movie");
        }
        public static void CreateMember()
        {
            StandardMessages.CreateMessage("a Member");
            Console.Write("Name of Member: ");
            string name = Console.ReadLine();

            Console.Write("Age of Member: ");
            string input = Console.ReadLine();
            int age = Validations.ParseInt(input);
            age = Validations.TryAgain(age);

            Member member = new Member(name, age);
            Database.MemberHandlers mh = new Database.MemberHandlers();

            mh.SaveMemberToDB(member);
            StandardMessages.WasCreatedMessage("member");

        }

        

    }
}
