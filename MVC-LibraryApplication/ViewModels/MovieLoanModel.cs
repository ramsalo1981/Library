using LibraryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_LibraryApplication.ViewModels
{
    public class MovieLoanModel
    {
        public List<Movie> Movies { get; set; }
        public List<Member> Members { get; set; }
        public Loan Loan { get; set; }
        public string ErrorMessage { get; set; }
    }
}
