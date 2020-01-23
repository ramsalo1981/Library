using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    public class LoanProcess
    {
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
                        Loan loan = LoanDataCapture.LoanBook(member, book, date);
                        LoanRepository.InsertBook(loan);
                        StandardMessages.LoanComplete(book.Name, loan.EndDate);
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
                        newDate = false;
                        Loan loan = LoanDataCapture.LoanMovie(member, movie, date);
                        LoanRepository.InsertMovie(loan);
                        StandardMessages.LoanComplete(movie.Name, loan.EndDate);
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
    }
}
