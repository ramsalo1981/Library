using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class DeleteItem
    {

        /// <summary>
        /// the user gets to select a book by index and delete it
        /// </summary>
        public static void DeleteBook()
        {
            Book book = CommonClasses.SelectBookById.SelectBook("delete");
            if (book != null)
            {
                BookRepository.DeleteBook(book.Id);
                StandardMessages.DeletedMessage("book");
            }

        }

        /// <summary>
        /// the user gets to select a movie by index and delete it
        /// </summary>
        public static void DeleteMovie()
        {
            Movie movie = CommonClasses.SelectMovieById.SelectMovie("delete");
            if (movie != null)
            {
                MovieRepository.DeleteMovie(movie.Id);
                StandardMessages.DeletedMessage("movie");
            }
        }
    }
}
