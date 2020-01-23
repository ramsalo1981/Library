using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class LoanProcess
    {
        public static void BorrowABook()
        {
            Member member = SelectMemberById.SelectMember("lend a book to");
            Book book = SelectBookById.SelectBook("lend");

            Database.LoanHandlers lh = new Database.LoanHandlers();

            if (book != null && member != null)
            {
                DateTime date = DateTime.Today;
                bool newDate = true;
                while (newDate)
                {
                    int availableBooks = lh.CheckBookLoansToCopies(book.Id, book.NumberOfCopies, date);
                    if (availableBooks > 0)
                    {
                        Loan loan = LoanDataCapture.LoanBook(member, book, date);
                        lh.InsertBook(loan);
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
                        date = LoanDataCapture.SelectNewDateBook(book.Id);
                    }

                }

            }
        }

        public static void BorrowAMovie()
        {
            Member member = SelectMemberById.SelectMember("lend a book to");
            Movie movie = SelectMovieById.SelectMovie("lend");

            Database.LoanHandlers lh = new Database.LoanHandlers();

            if (movie != null && member != null)
            {
                DateTime date = DateTime.Today;
                bool newDate = true;
                while (newDate)
                {
                    int result = lh.CheckMovieLoansToCopies(movie.Id, movie.NumberOfCopies, date);
                    if (result > 0)
                    {
                        newDate = false;
                        Loan loan = LoanDataCapture.LoanMovie(member, movie, date);
                        lh.InsertMovie(loan);
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
                        date = LoanDataCapture.SelectNewDateMovie(movie.Id);

                    }
                }
            }
        }
    }
}
