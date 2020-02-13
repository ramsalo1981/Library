using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using CommonClasses;
using System;
using LibraryRepository.Models;

namespace CommonClassesTests
{
    [TestClass]
    public class CheckLoansToCopiesTest
    {
        [TestMethod]
        [DataRow(1, 5, 5), DataRow(2, 5,2), DataRow(3, 5,3), DataRow(4, 5,2)]
        public void GetTheRightNumberOfCopiesTest(int selectedBook, int i, int expected)
        {
            DateTime date1 = DateTime.Today;
            DateTime date = date1.AddYears(1);
            Book book = SelectBookById.ValidateSelectedBook(selectedBook, i);
            int result = CheckLoansToCopies.Book(book.Id, expected, date);
            Assert.AreEqual(expected, result);
        }
    }
}
