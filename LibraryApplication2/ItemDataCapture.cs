using LibraryRepository.Models;
using LibraryRepository.Database;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    class ItemDataCapture
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

            BookRepository.SaveBookToDB(book);
            StandardMessages.WasCreatedMessage("book");
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

            MovieRepository.SaveMovieToDB(movie);

            StandardMessages.WasCreatedMessage("movie");
        }
        

        

    }
}
