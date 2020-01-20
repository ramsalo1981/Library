using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class SelectMovieById
    {
        

        public static Movie SelectMovie(string updateOrDelete)
        {
            Database.MovieHandlers mh = new Database.MovieHandlers();
            List<Movie> movies = mh.GetMoviesFromDB();

            StandardMessages.ListAllItems("movies");

            int i = 1;
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{i} {movie.Name} {movie.ReleseYear}");
                i++;
            }

            StandardMessages.SelectItemToDelete("movie", updateOrDelete);
            string input = Console.ReadLine();
            int.TryParse(input, out int indexSelected);

            bool isValid = Validations.SelectedIndex(indexSelected, i, movies.Count);
            if (isValid)
            {
                return movies[indexSelected - 1];
            }
            else
            {
                return null;
            }
        }
        public static void DeleteMovie()
        {
            Movie movie = SelectMovie("delete");
            Database.MovieHandlers mh = new Database.MovieHandlers();
            if (movie != null)
            {
                mh.DeleteMovieById(movie);
                StandardMessages.DeletedMessage("movie");
            }
        }
    }
}
