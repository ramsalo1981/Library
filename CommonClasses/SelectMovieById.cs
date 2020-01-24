using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class SelectMovieById
    {
        public static Movie SelectMovie(string updateOrDelete)
        {
            List<Movie> movies = MovieRepository.GetMovies();

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
            else if (indexSelected == 0)
            {
                return null;
            }
            else
            {
                StandardMessages.NothingToReturn("movies");
                return null;
            }
        }
    }
}
