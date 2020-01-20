﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class SelectBookById
    {

        public static Book SelectBook(string updateOrDelete)
        {
            Database.BookHandlers bh = new Database.BookHandlers();
            List<Book> books = bh.GetBooksFromDB();

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
        public static void DeleteBook()
        {
            Book book = SelectBook("delete");
            Database.BookHandlers bh = new Database.BookHandlers();
            if (book != null)
            {
                bh.DeleteBookById(book);
                StandardMessages.DeletedMessage("book");
            }

        }
       
    }
}