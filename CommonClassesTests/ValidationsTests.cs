using CommonClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClassesTests
{
    [TestClass]
    public class ValidationsTests
    {
        [TestMethod]
        [DataRow("gris", 0), DataRow("12", 12), DataRow("1.13", 0)]
        public void ParseIntTest(string input, int expected)
        {
            int result = Validations.ParseInt(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("nina", false), DataRow("lolilolonen", false), DataRow("Daniel", true), DataRow("ROFLET", false)]
        public void UserNameTest(string input, bool expected)
        {
            bool result = Validations.UserName(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("2020-03-01", "2020-03-02", -1), DataRow("2020-04-04", "2020-04-04", 0), DataRow("2020-10-01", "2020-01-01", 1)]
        public void CompareDatesTest(string firstDateInput, string secondDateInput, int expected)
        {
            DateTime firstDate = Convert.ToDateTime(firstDateInput);
            DateTime secondDate = Convert.ToDateTime(secondDateInput);

            int result = Validations.CompareDates(firstDate, secondDate);
            Assert.AreEqual(expected, result);
        }
    }
}
/// <summary>
/// Compares two dates and returns an int as a result (-1 if firstDate is before secondDate, 0 if firstDate and secondDate is the same, 1 if firstDate comes after secondDate)
/// </summary>
/// <param name="firstDate">first date input</param>
/// <param name="secondDate">second date to compare with firstDate</param>
/// <returns>result of the comparison as an int</returns>
//public static int CompareDates(DateTime firstDate, DateTime secondDate)
//{
//    int result = DateTime.Compare(firstDate, secondDate);
//    return result;
//}
