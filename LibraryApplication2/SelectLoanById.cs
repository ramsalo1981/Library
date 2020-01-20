using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class SelectLoanById
    {
        public static Loan SelectBookLoan()
        {
            Book book = SelectBookById.SelectBook("return");
            Database.LoanHandlers lh = new Database.LoanHandlers();
            if (book != null)
            {
                List<Loan> loans = lh.GetBookLoansById(book.Id);
                StandardMessages.ListAllItems("book loans");

                int i = 1;
                foreach (Loan loan in loans)
                {
                    var outputDate = loan.EndDate.ToString("yyyy-MM-dd");
                    Console.WriteLine($"{i} {loan.Member.Name} {loan.BookArticle.Name} {outputDate}");
                    i++;
                }
                StandardMessages.SelectItemToDelete("book", "return");
                string input = Console.ReadLine();
                int index = Validations.ParseInt(input);
                index = Validations.TryAgain(index);

                bool isValid = Validations.SelectedIndex(index, i, loans.Count);
                if (isValid)
                {
                    return loans[index - 1];
                }
                else
                {
                    StandardMessages.InvalidOption();
                    return null;
                }

            }
            else
            {
                StandardMessages.NothingToReturn("books");
                return null;
            }
        }

        public static Loan SelectMovieLoan()
        {
            Movie movie = SelectMovieById.SelectMovie("return");
            Database.LoanHandlers lh = new Database.LoanHandlers();
            if (movie != null)
            {
                List<Loan> loans = lh.GetMovieLoansById(movie.Id);
                StandardMessages.ListAllItems("movie loans");

                int i = 1;
                foreach (Loan loan in loans)
                {
                    var outputDate = loan.EndDate.ToString("yyyy-MM-dd");
                    Console.WriteLine($"{i} {loan.Member.Name} {loan.MovieArticle.Name} {outputDate}");
                    i++;
                }
                StandardMessages.SelectItemToDelete("movie", "return");
                string input = Console.ReadLine();
                int index = Validations.ParseInt(input);
                index = Validations.TryAgain(index);

                bool isValid = Validations.SelectedIndex(index, i, loans.Count);
                if (isValid)
                {
                    return loans[index - 1];
                }
                else
                {
                    StandardMessages.InvalidOption();
                    return null;
                }
            }
            else
            {
                StandardMessages.NothingToReturn("movies");
                return null;
            }

        }

    }
}
