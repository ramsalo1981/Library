using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class SelectBookById
    {
        /// <summary>
        /// The user selects a book by index and gets the chosen book returned
        /// </summary>
        /// <param name="updateOrDelete">a string that indicates whether to update or delete the book</param>
        /// <returns>the chosen book</returns>
        public static Book SelectBook(string updateOrDelete)
        {
            List<Book> books = BookRepository.GetBooks();

            StandardMessages.ListAllItems("books");

            int i = 1;
            foreach (Book book in books)
            {
                Console.WriteLine($"{i} {book.Name} {book.Author}");
                i++;
            }

            StandardMessages.SelectItemToDelete("book", updateOrDelete);
            string input = Console.ReadLine();
            int.TryParse(input, out int indexSelected);

            bool isValid = Validations.SelectedIndex(indexSelected, i, books.Count);
            if (isValid)
            {
                return books[indexSelected - 1];
            }
            else
            {
                return null;
            }

        }
    }
}
