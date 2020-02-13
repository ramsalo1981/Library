using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class LoanProcess
    {
        /// <summary>
        /// the user gets to select a book and check whether its available or not, if not the user gets to choose a new date yyyy-MM-dd
        /// </summary>
        /// <param name="member">the member to borrow the book</param>
        public static void BorrowABook(Member member)
        {
            Book book = SelectBookById.SelectBook("lend");
            if (book != null && member != null)
            {
                DateTime date = DateTime.Today;
                bool newDate = true;
                while (newDate)
                {
                    int availableBooks = CheckLoansToCopies.Book(book.Id, book.NumberOfCopies, date);
                    if (availableBooks > 0)
                    {
                        LoanProcessAvailableBooks(member, book, date);
                        newDate = false;
                    }
                    else
                    {
                        StandardMessages.OutOfCopies();
                        string input = Console.ReadLine();

                        if (input == "0")
                        {
                            newDate = false;
                        }
                        else
                        {
                            date = LoanDataCapture.SelectNewDateBook(book.Id);
                        }

                    }

                }

            }
        }
        private static void LoanProcessAvailableBooks(Member member, Book book, DateTime date)
        {
            Loan loan = LoanDataCapture.LoanBook(member, book, date);
            LoanRepository.InsertBook(loan);
            StandardMessages.LoanComplete(book.Name, loan.EndDate);
        }

        /// <summary>
        /// the user gets to select a movie and check whether its available or not, if not the user gets to choose a new date yyyy-MM-dd
        /// </summary>
        /// <param name="member">the member to borrow the movie</param>
        public static void BorrowAMovie(Member member)
        {
            Movie movie = SelectMovieById.SelectMovie("lend");

            if (movie != null && member != null)
            {
                DateTime date = DateTime.Today;
                bool newDate = true;
                while (newDate)
                {
                    int result = CheckLoansToCopies.Movie(movie.Id, movie.NumberOfCopies, date);
                    if (result > 0)
                    {
                        LoanProcessAvailableMovies(member, movie, date);
                        newDate = false;
                    }
                    else
                    {
                        StandardMessages.OutOfCopies();
                        string input = Console.ReadLine();

                        if (input == "0")
                        {
                            newDate = false;
                        }
                        else
                        {
                            date = LoanDataCapture.SelectNewDateMovie(movie.Id);
                        }

                    }
                }
            }
        }
        private static void LoanProcessAvailableMovies(Member member, Movie movie, DateTime date)
        {
            Loan loan = LoanDataCapture.LoanMovie(member, movie, date);
            LoanRepository.InsertMovie(loan);
            StandardMessages.LoanComplete(movie.Name, loan.EndDate);
        }
    }
}
