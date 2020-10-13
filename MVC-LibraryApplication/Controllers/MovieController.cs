using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace MVC_LibraryApplication.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = MovieRepository.GetMovies();
            return View(movies);
        }

        public IActionResult Details(string id)
        {
            ObjectId movieId = new ObjectId(id);
            Movie movie = MovieRepository.GetMovieById(movieId);

            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, int releseYear, string genre, int numberOfCopies, int duration, int agelimit)
        {
            Movie movie = new Movie(name, releseYear, genre, numberOfCopies, duration, agelimit);
            MovieRepository.SaveMovieToDB(movie);
            return Redirect("/Movie");
        }
        public IActionResult Edit(string id)
        {
            ObjectId movieId = new ObjectId(id);
            Movie movie = MovieRepository.GetMovieById(movieId);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(string id, string name, int releseYear, string genre, int numberOfCopies, int duration, int agelimit)
        {
            ObjectId movieId = new ObjectId(id);
            Movie updatedMovie = new Movie(name, releseYear, genre, numberOfCopies, duration, agelimit);
            MovieRepository.UpdateMovie(movieId, updatedMovie);
            return Redirect("/Movie");
        }

        public IActionResult Delete(string id)
        {
            ObjectId movieId = new ObjectId(id);
            Movie movie = MovieRepository.GetMovieById(movieId);

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(string id)
        {
            ObjectId movieId = new ObjectId(id);
            MovieRepository.DeleteMovie(movieId);
            return Redirect("/Movie");
        }
    }
}