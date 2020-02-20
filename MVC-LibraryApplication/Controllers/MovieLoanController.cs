using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonClasses;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MVC_LibraryApplication.ViewModels;
using Serilog;

namespace MVC_LibraryApplication.Controllers
{
    public class MovieLoanController : Controller
    {
        public IActionResult Index()
        {
            List<Loan> loans = MovieLoanRepository.GetAllMovieLoans();
            return View(loans);
        }
        public IActionResult Create()
        {
            MovieLoanModel mlm = CreateMovieLoanModel();
            return View(mlm);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(string memberId, string movieId, DateTime startDate, DateTime endDate)
        {
            ObjectId memberOId = new ObjectId(memberId);
            ObjectId movieOId = new ObjectId(movieId);

            Movie movie = MovieRepository.GetMovieById(movieOId);

            Loan loan = CreateLoan(memberOId, movie.Id, startDate, endDate);
            int copiesRemaining = CheckLoansToCopies.Movie(movie.Id, movie.NumberOfCopies, startDate, endDate);
            if (copiesRemaining > 0)
            {
                MovieLoanRepository.InsertMovie(loan);
                return Redirect("/MovieLoan");
            }
            else if (copiesRemaining <= 0)
            {
                SerilogMVC(movie);
                string errorMessage = "No availiable copies at that date. Please try an other one";
                MovieLoanModel movieLoanModel = CreateMovieLoanModel();
                movieLoanModel.ErrorMessage = errorMessage;
                return View(movieLoanModel);
            }
            return Redirect("/MovieLoan");


        }

        public IActionResult Edit(string id)
        {
            ObjectId movieLoanId = new ObjectId(id);
            Loan loan = MovieLoanRepository.GetMovieLoanByMovieLoanId(movieLoanId);
            return View(loan);
        }

        [HttpPost]
        public IActionResult Edit(string id, DateTime startDate, DateTime endDate)
        {
            ObjectId loanId = new ObjectId(id);
            MovieLoanRepository.UpdateMovieLoan(loanId, startDate, endDate);

            return Redirect("/MovieLoan");
        }

        public IActionResult Delete(string id)
        {
            ObjectId loanId = new ObjectId(id);
            MovieLoanRepository.DeleteMovieLoan(loanId);

            return Redirect("/MovieLoan");
        }

        public IActionResult Details(string id)
        {
            ObjectId loanId = new ObjectId(id);
            Loan loan = MovieLoanRepository.GetMovieLoanByMovieLoanId(loanId);

            return View(loan);
        }


        private Loan CreateLoan(ObjectId memberId, ObjectId movieId, DateTime startDate, DateTime endDate)
        {
            Member member = MemberRepository.GetMemberById(memberId);
            Movie movie = MovieRepository.GetMovieById(movieId);

            Loan loan = new Loan(startDate, endDate, member);
            loan.MovieArticle = movie;

            return loan;
        }
        private MovieLoanModel CreateMovieLoanModel()
        {
            MovieLoanModel mlm = new MovieLoanModel();
            mlm.Members = GetMembers();
            mlm.Movies = GetMovies();
            return mlm;
        }
        private List<Member> GetMembers()
        {
            List<Member> members = MemberRepository.GetMembers();
            return members;
        }
        private List<Movie> GetMovies()
        {
            List<Movie> movies = MovieRepository.GetMovies();
            return movies;
        }

        public static void SerilogMVC(Movie movie)
        {
            var log = new LoggerConfiguration()
           .MinimumLevel.Debug()
           .WriteTo.MongoDB("mongodb://localhost/serilog-db", collectionName: "Movie")
           .CreateLogger();

            log.Fatal($"Tried to rent the movie {movie.Name} at {DateTime.Now} without success Movie Id: {movie.Id}");
        }
    }
}