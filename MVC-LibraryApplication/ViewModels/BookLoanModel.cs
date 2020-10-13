using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LibraryApplication.ViewModels
{
    public class BookLoanModel
    {
        public List<Member> Members { get; set; } = MemberRepository.GetMembers();
        public List<Book> Books { get; set; } = BookRepository.GetBooks();
        public Loan Loan { get; set; }
        public string ErrorMessage { get; set; }
    }
}
