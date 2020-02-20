using LibraryRepository.Models;
using LibraryRepository.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class SelectBookById
    {
        private static List<Book> books = BookRepository.GetBooks();

        /// <summary>
        /// The user selects a book by index and gets the chosen book returned
        /// </summary>
        /// <param name="updateOrDelete">a string that indicates whether to update or delete the book</param>
        /// <returns>the chosen book</returns>
        public static Book SelectBook(string updateOrDelete)
        {
            int i = PrintsAndReturnNumberOfBooks();
            int indexSelected = SelectedBookInput(updateOrDelete);
            Book book = ValidateSelectedBook(indexSelected,  i);
            return book;

        }

        /// <summary>
        /// Prints the list of books to the user
        /// </summary>
        /// <returns>the number of books in the list</returns>
        private static int PrintsAndReturnNumberOfBooks()
        {
            int i = 1;
            StandardMessages.ListAllItems("books");
            foreach (Book book in books)
            {
                Console.WriteLine($"{i} {book.Name} {book.Author}");
                i++;
            }
            return i-1;
        }

        /// <summary>
        /// Prints the select a book message and lets the user select an index of a book to borrow
        /// </summary>
        /// <param name="updateOrDelete"></param>
        /// <returns>the selected index by the user</returns>
        private static int SelectedBookInput(string updateOrDelete)
        {
            StandardMessages.SelectItemToDelete("book", updateOrDelete);
            string input = Console.ReadLine();
            int.TryParse(input, out int indexSelected);
            return indexSelected;

        }

        /// <summary>
        /// Validates that the index selected by the user is a valid choice
        /// </summary>
        /// <param name="indexSelected"></param>
        /// <param name="i"></param>
        /// <returns>the chosen book</returns>
        public static Book ValidateSelectedBook(int indexSelected, int i)
        {
            bool isValid = Validations.SelectedIndex(indexSelected, i, books.Count);
            if (isValid)
            {
                return books[indexSelected - 1];
            }
            else if (indexSelected == 0)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
