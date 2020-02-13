using LibraryRepository.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CommonClasses;

namespace CommonClassesTests
{
    [TestClass]
    public class SelectBookByIdTest
    {
        [TestMethod]
        [DataRow(1, 5, "Lord of the Flies"), DataRow(2, 5, "bok1"), DataRow(3, 5, "saga2000"), DataRow(4, 5, "sagan om ringen")]
        public void SelectBookByIdTests(int selectedBook, int i, string expectedBookName)
        {
            Book book = SelectBookById.ValidateSelectedBook(selectedBook, i);
            Assert.AreEqual(expectedBookName, book.Name);
        }
    }
}
