using LibraryRepository.Database;
using LibraryRepository.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Repositories
{
    public class BookLoanRepository
    {
        public static void InsertBookLoan(Loan loan)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            lh.InsertBook(loan);
        }
        public static List<Loan> GetAllBookLoans()
        {
            BookLoanHandlers blh = new BookLoanHandlers();
            return blh.GetAllBookLoans();
        }
        public static List<Loan> GetBookLoansById(ObjectId id)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            return lh.GetBookLoansById(id);
        }
        public static List<Loan> GetBookLoansByMember(Member member)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            return lh.GetBookLoansByMember(member);
        }
        public static void ReturnBook(Loan loanToReturn, DateTime returnDate)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            lh.ReturnBook(loanToReturn, returnDate);
        }

        public static Loan GetBookLoanByBookLoanId(ObjectId bookLoanId)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            return lh.GetBookLoanByBookLoanId(bookLoanId);
        }

        public static void UpdateBookLoan(ObjectId loanId, DateTime startDate, DateTime endDate)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            lh.UpdateBookLoan(loanId, startDate, endDate);
        }

        public static void DeleteBookLoan(ObjectId loanId)
        {
            BookLoanHandlers lh = new BookLoanHandlers();
            lh.DeleteBookLoan(loanId);
        }
    }
}
