using LibraryRepository.Factory;
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
                DateTime startDate = DateTime.Today;
                
                bool newDate = true;
                while (newDate)
                {
                    DateTime endDate = startDate.AddMonths(1);

                    int availableBooks = CheckLoansToCopies.Book(book.Id, book.NumberOfCopies, startDate, endDate);
                    if (availableBooks > 0)
                    {
                        LoanProcessAvailableBooks(member, book, startDate, endDate);
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
                            startDate = SelectNewLoanDate.SelectNewDateBook(book.Id);
                        }

                    }

                }

            }
        }
        private static void LoanProcessAvailableBooks(Member member, Book book, DateTime startDate, DateTime endDate)
        {
            Loan loan = Factory.CreateLoan(startDate, endDate, member);
            loan.BookArticle = book;
            BookLoanRepository.InsertBookLoan(loan);
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
                DateTime startDate = DateTime.Today;

                bool newDate = true;
                while (newDate)
                {
                    DateTime endDate = startDate.AddMonths(1);
                    int result = CheckLoansToCopies.Movie(movie.Id, movie.NumberOfCopies, startDate, endDate);
                    if (result > 0)
                    {
                        LoanProcessAvailableMovies(member, movie, startDate, endDate);
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
                            startDate = SelectNewLoanDate.SelectNewDateMovie(movie.Id);
                        }

                    }
                }
            }
        }
        private static void LoanProcessAvailableMovies(Member member, Movie movie, DateTime startDate, DateTime endDate)
        {
            Loan loan = Factory.CreateLoan(startDate, endDate, member);
            loan.MovieArticle = movie;
            MovieLoanRepository.InsertMovie(loan);
            StandardMessages.LoanComplete(movie.Name, loan.EndDate);
        }
    }
}
