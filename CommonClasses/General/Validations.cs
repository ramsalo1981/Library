using LibraryRepository.Models;
using LibraryRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class Validations
    {
        /// <summary>
        /// Checks if the indexSelected is not 0, which means exit
        /// checks if the indexSelected is not greater than i-1 which means that there is no such index
        /// checks if the count is greater than zero, otherwise there is no index to be chosen
        /// </summary>
        /// <param name="indexSelected">index int chosen by the user</param>
        /// <param name="i">the number of objects in the list -1</param>
        /// <param name="count">Makes sure there is an option to chose... if there is no objects "int i" will still be 1</param>
        /// <returns>true if the selectedIndex is valid, otherwise false</returns>
        public static bool SelectedIndex(int indexSelected, int i, int count)
        {

            if (indexSelected == 0)
            {
                return false;
            }
            else if (indexSelected > i)
            {
                StandardMessages.OutOfRange();
                return false;
            }
            else if (count >= 1)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Compares two dates and returns an int as a result (-1 if firstDate is before secondDate, 0 if firstDate and secondDate is the same, 1 if firstDate comes after secondDate)
        /// </summary>
        /// <param name="firstDate">first date input</param>
        /// <param name="secondDate">second date to compare with firstDate</param>
        /// <returns>result of the comparison as an int</returns>
        public static int CompareDates(DateTime firstDate, DateTime secondDate)
        {
            int result = DateTime.Compare(firstDate, secondDate);
            return result;
        }

        /// <summary>
        /// Tries to convert a string added by the user to a DateTime type
        /// </summary>
        /// <param name="dateInput">strings added by the user, until its valid</param>
        /// <returns>the valid DateTime</returns>
        public static DateTime Date(string dateInput)
        {
            DateTime validDate = new DateTime();
            bool valid = false;
            while (!valid)
            {
                try
                {
                    validDate = Convert.ToDateTime(dateInput);
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Date Input, please try again (yyyy-mm-dd)");
                    dateInput = Console.ReadLine();
                }
            }
            return validDate;
        }

        /// <summary>
        /// try to parse a string if the lenght i less or equal to four, catches format and overflow exception and
        /// prints the appropriate message to the user, if the user fails to enter a valid option an int of the value 0 returns.
        /// </summary>
        /// <param name="input">a string written by the user</param>
        /// <returns>the int parsed string or int value 0</returns>
        public static int ParseInt(string input)
        {
            try
            {
                if (input.Length <= 4)
                {
                    return int.Parse(input);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You need to enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered was out of bounds");
            }
            return 0;
        }

        /// <summary>
        /// gets an int that is already try int parsed from a string, if the value of the int is 0.
        /// the user gets to keep trying to input and valid string to get int parsed in the function "ParseInt()"
        /// </summary>
        /// <param name="enteredNumber">the number already parsed in ParseInt()</param>
        /// <returns>a valid number</returns>
        public static int TryAgain(int enteredNumber)
        {
            if (enteredNumber == 0)
            {
                while (enteredNumber == 0)
                {
                    Console.Write("Please try again: ");
                    string input = Console.ReadLine();
                    enteredNumber = ParseInt(input);
                }
            }
            return enteredNumber;
        }

        /// <summary>
        /// Checks if there is a member with the same username that the user entered
        /// </summary>
        /// <param name="userName">a name entered by the user</param>
        /// <returns>true or false if there is a member with the entered username</returns>
        public static bool UserName(string userName)
        {
            bool validUserName = false;
            List<Member> members = MemberRepository.GetMembers();
            foreach (Member member in members)
            {
                if (member.Name == userName)
                {
                    validUserName = true;
                }
            }
            return validUserName;
        }
    }
}
