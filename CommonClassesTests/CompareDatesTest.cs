using CommonClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClassesTests
{
    [TestClass]
    public class CompareDatesTest
    {
        [TestMethod]
        [DataRow("2020-01-01", "2020-01-01"), DataRow("2121-04-13", "2121-04-13")]
        public void CompareDatesTests(string dateInput, string dateOutput)
        {
            DateTime date = Validations.Date(dateInput);
            dateOutput = date.ToString("yyyy-MM-dd");
            Assert.AreEqual(dateOutput, dateInput);
        }
    }
}
