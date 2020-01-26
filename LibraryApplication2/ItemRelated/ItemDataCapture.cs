using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using CommonClasses;
using LibraryRepository.Factory;

namespace LibraryApplication2
{
    class ItemDataCapture
    {

        /// <summary>
        /// the user gets to enter the property values of a book, and than gets and Book object returned
        /// </summary>
        /// <returns>a Book object</returns>
        public static Book Book()
        {
            Console.Write("Name of the Book: ");
            string name = Console.ReadLine();

            Console.Write("Relese year of the Book: ");
            string input = Console.ReadLine();
            int releseYear = Validations.ParseInt(input);
            releseYear = Validations.TryAgain(releseYear);

            Console.Write("Genre of the Book: ");
            string genre = Console.ReadLine();

            Console.Write("Number of copies of the Book: ");
            input = Console.ReadLine();
            int numberOfCopies = Validations.ParseInt(input);
            numberOfCopies = Validations.TryAgain(numberOfCopies);

            Console.Write("Name of Author: ");
            string author = Console.ReadLine();

            Console.Write("Pages of the Book: ");
            input = Console.ReadLine();
            int pages = Validations.ParseInt(input);
            pages = Validations.TryAgain(pages);

            Book book = Factory.CreateBook(name, "book", releseYear, genre, numberOfCopies, author, pages);
            return book;
        }

        /// <summary>
        /// the user gets to enter the property values of a movie, and than gets and Movie object returned
        /// </summary>
        /// <returns>a Movie object</returns>
        public static Movie Movie()
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

            Movie movie = Factory.CreateMovie(name, "movie", releseYear, genre, numberOfCopies, duration, ageLimit);
            return movie;
        }
    }
}
