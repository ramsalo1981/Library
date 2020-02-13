using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    /// <summary>
    /// the user gets to choose which book loan of the members book loans to return
    /// the book loans endDate gets updated to DateTime.Today
    /// </summary>
    public class ReturnItem
    {
        public static void UpdateBookLoan(Member member)
        {
            Loan loanToReturn = SelectLoanById.SelectBookLoan(member);

            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                LoanRepository.ReturnBook(loanToReturn, returnDate);

                StandardMessages.ItemReturned("book");
            }
            else
            {
                StandardMessages.NothingToReturn("books");
            }
        }

        /// <summary>
        /// the user gets to choose which movie loan of the members movie loans to return
        /// the book loans endDate gets updated to DateTime.Today
        /// </summary>
        public static void UpdateMovieLoan(Member member)
        {
            Loan loanToReturn = SelectLoanById.SelectMovieLoan(member);
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                LoanRepository.ReturnMovie(loanToReturn, returnDate);

                StandardMessages.ItemReturned("movie");
            }
            else
            {
                StandardMessages.NothingToReturn("movies");
            }
        }
    }
}
