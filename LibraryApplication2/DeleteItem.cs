using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class DeleteItem
    {
        public static void DeleteBook()
        {
            Book book = CommonClasses.SelectBookById.SelectBook("delete");
            if (book != null)
            {
                BookRepository.DeleteBook(book);
                StandardMessages.DeletedMessage("book");
            }

        }
        public static void DeleteMovie()
        {
            Movie movie = CommonClasses.SelectMovieById.SelectMovie("delete");
            if (movie != null)
            {
                MovieRepository.DeleteMovie(movie);
                StandardMessages.DeletedMessage("movie");
            }
        }
    }
}
