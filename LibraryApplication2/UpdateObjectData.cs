using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    public class UpdateObjectData
    {
        public static void UpdateBookLoan(Member member)
        {
            Loan loanToReturn = SelectLoanById.SelectBookLoan(member);
            
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                LoanRepository.ReturnBook(loanToReturn, returnDate);

                StandardMessages.ItemReturned("book");
            }
        }
        public static void UpdateMovieLoan(Member member)
        {
            Loan loanToReturn = SelectLoanById.SelectMovieLoan(member);
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                LoanRepository.ReturnMovie(loanToReturn, returnDate);

                StandardMessages.ItemReturned("movie");
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

                MemberRepository.UpdateMember(memberToUpdate.Id, name, age);
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

                BookRepository.UpdateBook(bookToUpdate, updatedBook);

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

                MovieRepository.UpdateMovie(movieToUpdate, updatedMovie);

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
