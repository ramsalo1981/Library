using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    class SelectLoanById
    {
        public static Loan SelectBookLoan(Member member)
        {
            //Book book = SelectBookById.SelectBook("return");
            List<Book> book = BookRepository.GetBooks();
            if (book.Count > 0)
            {
                List<Loan> loans = LoanRepository.GetBookLoans(member);
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
                    return null;
                }

            }
            else
            {
                StandardMessages.NothingToReturn("books");
                return null;
            }
        }

        public static Loan SelectMovieLoan(Member member)
        {
            Movie movie = SelectMovieById.SelectMovie("return");

            if (movie != null)
            {
                List<Loan> loans = LoanRepository.GetMovieLoansByMember(member);
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
