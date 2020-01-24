using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
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
        }
        public static void UpdateMovieLoan(Member member)
        {
            Loan loanToReturn = SelectLoanById.SelectMovieLoan(member);
            if (loanToReturn != null)
            {
                DateTime returnDate = DateTime.Today;
                LoanRepository.ReturnMovie(loanToReturn, returnDate);

                StandardMessages.ItemReturned("movie");
            }
        }
    }
}
