using LibraryRepository.Models;
using LibraryRepository.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class CheckLoansToCopies
    {
        public static int Book(ObjectId bookId, int numberOfCopies, DateTime date)
        {
            List<Loan> loans = LoanRepository.GetBookLoansById(bookId);

            foreach (Loan loan in loans)
            {
                int checkStartDate = Validations.CompareDates(date, loan.StartDate);
                int checkEndDate = Validations.CompareDates(date, loan.EndDate);

                if (checkStartDate >= 0 && checkEndDate <= 0)
                {
                    numberOfCopies -= 1;
                }
                else if (true)
                {
                    DateTime endDate = date.AddMonths(3);
                    checkStartDate = Validations.CompareDates(endDate, loan.StartDate);
                    checkEndDate = Validations.CompareDates(endDate, loan.EndDate);

                    if (checkStartDate >= 0 && checkEndDate <= 0)
                    {
                        numberOfCopies -= 1;
                    }
                }
            }
            return numberOfCopies;
        }

        public static int Movie(ObjectId id, int numberOfCopies, DateTime date)
        {
            List<Loan> loans = LoanRepository.GetMovieLoansById(id);
            foreach (Loan loan in loans)
            {
                int checkStartDate = Validations.CompareDates(date, loan.StartDate);
                int checkEndDate = Validations.CompareDates(date, loan.EndDate);

                if (checkStartDate >= 0 && checkEndDate <= 0)
                {
                    numberOfCopies -= 1;
                }
                else if (true)
                {
                    DateTime endDate = date.AddMonths(3);
                    checkStartDate = Validations.CompareDates(endDate, loan.StartDate);
                    checkEndDate = Validations.CompareDates(endDate, loan.EndDate);

                    if (checkStartDate >= 0 && checkEndDate <= 0)
                    {
                        numberOfCopies -= 1;
                    }
                }
            }
            return numberOfCopies;
        }
    }
}
