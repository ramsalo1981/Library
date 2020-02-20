using LibraryRepository.Database;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Repositories
{
    public class MovieLoanRepository
    {
        public static void InsertMovie(Loan loan)
        {
            MovieLoanHandlers lh = new MovieLoanHandlers();
            lh.InsertMovie(loan);
        }


        public static List<Loan> GetAllMovieLoans()
        {
            MovieLoanHandlers mlh = new MovieLoanHandlers();
            return mlh.GetAllMovieLoans();
        }

        public static List<Loan> GetMovieLoansById(ObjectId id)
        {
            MovieLoanHandlers lh = new MovieLoanHandlers();
            return lh.GetMovieLoansById(id);
        }
        public static List<Loan> GetMovieLoansByMember(Member member)
        {
            MovieLoanHandlers lh = new MovieLoanHandlers();
            return lh.GetMovieLoansByMember(member);
        }
        public static void ReturnMovie(Loan loanToReturn, DateTime returnDate)
        {
            MovieLoanHandlers lh = new MovieLoanHandlers();
            lh.ReturnMovie(loanToReturn, returnDate);
        }

        public static Loan GetMovieLoanByMovieLoanId(ObjectId movieloanId)
        {
            MovieLoanHandlers mlh = new MovieLoanHandlers();
            return mlh.GetAllMovieLoanByMovieLoanId(movieloanId);
        }

        public static void UpdateMovieLoan(ObjectId loanId, DateTime startDate, DateTime endDate)
        {
            MovieLoanHandlers mlh = new MovieLoanHandlers();
            mlh.UpdateMovieLoan(loanId, startDate, endDate);
        }

        public static void DeleteMovieLoan(ObjectId loanId)
        {
            MovieLoanHandlers mlh = new MovieLoanHandlers();
            mlh.DeleteMovieLoan(loanId);
        }

        public static Loan GetMovieLoanById(ObjectId movieLoanId)
        {
            MovieLoanHandlers mlh = new MovieLoanHandlers();
            return mlh.GetMovieLoanByMovieLoanId(movieLoanId);
        }
    }
}
