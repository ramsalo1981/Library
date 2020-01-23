using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class Validations
    {
        public static bool SelectedIndex(int indexSelected, int i, int count)
        {
            if (indexSelected == 0)
            {
                return false;
            }
            else if (indexSelected > i - 1)
            {
                StandardMessages.OutOfRange();
                return false;
            }
            else if (indexSelected != 0 || count != 0)
            {
                return true;
            }
            else
                return false;
        }
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
        public static int CompareDates(DateTime date, DateTime endDate)
        {

            int result = DateTime.Compare(date, endDate);
            return result;
        }
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


    }
}
