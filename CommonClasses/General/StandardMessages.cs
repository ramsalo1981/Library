using System;
using System.Collections.Generic;
using System.Text;

namespace CommonClasses
{
    public class StandardMessages
    {
        /// <summary>
        /// prints the header of the application
        /// </summary>
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("======================================================================");
            Console.WriteLine("*********              -------------------                   *********");
            Console.WriteLine("---------              Library Application                   ---------");
            Console.WriteLine("*********              -------------------                   *********");
            Console.WriteLine("======================================================================\n\n");
        }

        public static void ChooseMemberOptions(string option)
        {
            Console.WriteLine($"Select a member to {option}\n");
        }

        public static void ItemReturned(string itemType)
        {
            Console.WriteLine($"Your {itemType} has been returned");
            Console.ReadLine();
        }
        /// <summary>
        /// prints a message that the users input was invalid
        /// </summary>
        public static void InvalidOption()
        {
            Console.WriteLine("You selected an invalid option, please try again");
            Console.ReadLine();
        }
        public static void ListAllItems(string item)
        {
            Header();
            Console.WriteLine($"========== List of all {item} in the database ==========\n");
        }

        /// <summary>
        /// prints that the users input was out of bounds
        /// </summary>
        public static void OutOfRange()
        {
            Console.WriteLine("Your selected index number was out of range!");
            Console.ReadLine();
        }
        public static void OutOfCopies()
        {
            Console.WriteLine("Your Item has no available copies, do you want to reserve another date?");
            Console.Write("Press enter if you do... [0] if you want to exit: ");

        }
        public static void LoanComplete(string name, DateTime endDate)
        {
            var outputDate = endDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"You borrowed {name}, please return it before {outputDate}, thanks!");
            Console.ReadLine();
        }
        public static void SelectItemToDelete(string item, string deleteOrUpdate)
        {
            Console.Write($"Select a {item} to {deleteOrUpdate} by index number or 0 to exit: ");

        }
        public static void NothingToReturn(string item)
        {
            Console.WriteLine($"There is no {item} to return");
            Console.ReadLine();
        }
        public static void ExitMessage()
        {
            Console.WriteLine("Thanks for now, please come again!");
            Console.ReadLine();
        }
    }
}
