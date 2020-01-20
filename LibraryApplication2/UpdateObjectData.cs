using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class UpdateObjectData
    {
        public static void UpdateBookLoan()
        {
            Loan loanToReturn = SelectLoanById.SelectBookLoan();
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                Database.LoanHandlers lh = new Database.LoanHandlers();
                lh.ReturnBook(loanToReturn, returnDate);

                StandardMessages.ItemReturned("book");
            }
        }
        public static void UpdateMovieLoan()
        {
            Loan loanToReturn = SelectLoanById.SelectMovieLoan();
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                Database.LoanHandlers lh = new Database.LoanHandlers();
                lh.ReturnMovie(loanToReturn, returnDate);

                StandardMessages.ItemReturned("book");
            }
        }
        private static void UpdateMember()
        {
            Member memberToUpdate = SelectMemberById.SelectMember("update");
            if (memberToUpdate != null)
            {
                Console.Write("New name of Member: ");
                string name = Console.ReadLine();
                Console.Write("New age of Member: ");
                int age = int.Parse(Console.ReadLine());

                Database.MemberHandlers mh = new Database.MemberHandlers();
                mh.UpdateMember(memberToUpdate.Id, name, age);
                StandardMessages.UpdatedMessage("member");
            }
        }
        private static void UpdateBook()
        {
            Book bookToUpdate = SelectBookById.SelectBook("update");
            if (bookToUpdate != null)
            {
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

                Console.Write("Name of Author: ");
                string author = Console.ReadLine();

                Console.Write("Pages of the book: ");
                input = Console.ReadLine();
                int pages = Validations.ParseInt(input);
                pages = Validations.TryAgain(pages);

                Book updatedBook = new Book(name, "book", releseYear, genre, numberOfCopies, author, pages);

                Database.BookHandlers bh = new Database.BookHandlers();
                bh.UpdateBook(bookToUpdate, updatedBook);

                StandardMessages.UpdatedMessage("book");
            }

        }
        private static void UpdateMovie()
        {
            Movie movieToUpdate = SelectMovieById.SelectMovie("update");

            if (movieToUpdate != null)
            {
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

                Console.Write("Duration (minutes) of the Movie: ");
                input = Console.ReadLine();
                int duration = Validations.ParseInt(input);
                duration = Validations.TryAgain(duration);

                Console.Write("Age limit of the Movie: ");
                input = Console.ReadLine();
                int ageLimit = Validations.ParseInt(input);
                ageLimit = Validations.TryAgain(ageLimit);

                Movie updatedMovie = new Movie(name, "movie", releseYear, genre, numberOfCopies, duration, ageLimit);

                Database.MovieHandlers mh = new Database.MovieHandlers();
                mh.UpdateMovie(movieToUpdate, updatedMovie);

                StandardMessages.UpdatedMessage("movie");
            }
        }
        public static void UpdateSwitch()
        {
            StandardMessages.SelectList("Update");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    UpdateBook();
                    break;
                case "2":
                    UpdateMovie();
                    break;
                case "3":
                    UpdateMember();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
