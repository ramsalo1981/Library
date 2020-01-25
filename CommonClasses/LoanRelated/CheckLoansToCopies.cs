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
        /// <summary>
        /// Compares start date and end date to already lend out book, if the dates interferes with each other, numberOfCopies -= 1
        /// </summary>
        /// <param name="bookId">the book to borrow</param>
        /// <param name="numberOfCopies">number of copies of the chosen book</param>
        /// <param name="date">the selected start date</param>
        /// <returns>how many copies that remains</returns>
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

        /// <summary>
        /// Compares start date and end date to already lend out movie, if the dates interferes with each other, numberOfCopies -= 1
        /// </summary>
        /// <param name="movieId">the movie to borrow</param>
        /// <param name="numberOfCopies">number of copies of the chosen movie</param>
        /// <param name="date">the selected start date</param>
        /// <returns>how many copies that remains</returns>
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
