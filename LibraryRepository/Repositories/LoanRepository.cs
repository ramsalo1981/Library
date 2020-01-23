using LibraryRepository.Database;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Repositories
{
    public class LoanRepository
    {
        public static void InsertBook(Loan loan)
        {
            LoanHandlers lh = new LoanHandlers();
            lh.InsertBook(loan);
        }
        public static List<Loan> GetBookLoansById(ObjectId id)
        {
            LoanHandlers lh = new LoanHandlers();
            return lh.GetBookLoansById(id);
        }
        public static List<Loan> GetBookLoans(Member member)
        {
            LoanHandlers lh = new LoanHandlers();
            return lh.GetBookLoansByMember(member);
        }
        public static void ReturnBook(Loan loanToReturn, DateTime returnDate)
        {
            LoanHandlers lh = new LoanHandlers();
            lh.ReturnBook(loanToReturn, returnDate);
        }

        public static void InsertMovie(Loan loan)
        {
            LoanHandlers lh = new LoanHandlers();
            lh.InsertMovie(loan);
        }
        public static List<Loan> GetMovieLoansById(ObjectId id)
        {
            LoanHandlers lh = new LoanHandlers();
            return lh.GetMovieLoansById(id);
        }
        public static List<Loan> GetMovieLoansByMember(Member member)
        {
            LoanHandlers lh = new LoanHandlers();
            return lh.GetMovieLoansByMember(member);
        }
        public static void ReturnMovie(Loan loanToReturn, DateTime returnDate)
        {
            LoanHandlers lh = new LoanHandlers();
            lh.ReturnMovie(loanToReturn, returnDate);
        }
    }
}
