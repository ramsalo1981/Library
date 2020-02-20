using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace CommonClasses
{
    public class SelectLoanById
    {
        /// <summary>
        /// The user selects a book loan by index and gets the chosen book loan returned
        /// </summary>
        /// <returns>the chosen book loan</returns>
        public static Loan SelectBookLoan(Member member)
        {
            List<Book> book = BookRepository.GetBooks();
            if (book.Count > 0)
            {
                List<Loan> loans = BookLoanRepository.GetBookLoansByMember(member);
                StandardMessages.ListAllItems("your book loans");

                int i = 1;
                foreach (Loan loan in loans)
                {
                    var outputDate = loan.EndDate.ToString("yyyy-MM-dd");
                    Console.WriteLine($"{i} {loan.Member.Name} {loan.BookArticle.Name} {outputDate}");
                    i++;
                }
                StandardMessages.SelectItemToDelete("book", "return");
                string input = Console.ReadLine();
                if (input != "0")
                {
                    int index = Validations.ParseInt(input);

                    bool isValid = Validations.SelectedIndex(index, i, loans.Count);
                    if (isValid)
                    {
                        return loans[index - 1];
                    }
                    else
                    {
                        StandardMessages.InvalidOption();
                        input = Console.ReadLine();
                        return null;
                    }
                }
                else
                {
                    return null;
                }

            }
            else
            {
                StandardMessages.NothingToReturn("books");
                return null;
            }
        }

        /// <summary>
        /// The user selects a movie loan by index and gets the chosen movie loan returned
        /// </summary>
        /// <returns>the chosen movie loan</returns>
        public static Loan SelectMovieLoan(Member member)
        {
            Movie movie = SelectMovieById.SelectMovie("return");

            if (movie != null)
            {
                List<Loan> loans = MovieLoanRepository.GetMovieLoansByMember(member);
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
                
                if (input != "0")
                {
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
                return null;

            }
            else
            {

                return null;
            }

        }

    }
}
