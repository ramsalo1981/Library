using LibraryRepository.Factory;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    class SelectNewLoanDate
    {

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
