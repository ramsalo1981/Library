using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Factory
{
    public class Factory
    {
        public static Loan CreateLoan(DateTime startDate, DateTime endDate, Member member)
        {
            Loan loan = new Loan(startDate, endDate, member);
            return loan;
        }

        public static Book CreateBook(string name, int releseYear, string genre, int numberOfCopies, string author, int pages)
        {
            Book book = new Book(name, releseYear, genre, numberOfCopies, author, pages);
            return book;
        }

        public static Movie CreateMovie(string name, int releseYear, string genre, int numberOfCopies, int duration, int ageLimit)
        {
            Movie movie = new Movie(name, releseYear, genre, numberOfCopies, duration, ageLimit);
            return movie;
        }

        public static Member CreateMember(string name, int age)
        {
            Member member = new Member(name, age);
            return member;
        }
    }
}
