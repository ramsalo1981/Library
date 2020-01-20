using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class StandardMessages
    {
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("======================================================================");
            Console.WriteLine("*********              -------------------                   *********");
            Console.WriteLine("---------              Library Application                   ---------");
            Console.WriteLine("*********              -------------------                   *********");
            Console.WriteLine("======================================================================\n\n");
        }

        internal static void ItemReturned(string itemType)
        {
            Console.WriteLine($"Your {itemType} has been returned");
            Console.ReadLine();
        }

        public static void SelectItemToDelete(string item, string deleteOrUpdate)
        {
            Console.Write($"Select a {item} to {deleteOrUpdate} by index number or 0 to exit: ");
        
        }
        public static void DeletedMessage(string item)
        {
            Console.WriteLine($"The {item} was deleted");
            Console.ReadLine();
        }
        public static void WasCreatedMessage(string item)
        {
            Console.WriteLine($"You've created a new {item}");
            Console.ReadLine();
        }
        public static void CreateMessage(string item)
        {
            Header();
            Console.WriteLine($"========== Create {item}! ==========");
        }
        public static void UpdatedMessage(string item)
        {
            Console.WriteLine($"Your {item} has been updated");
            Console.ReadLine();
        }
        public static void BookOrMovieMessage()
        {
            Console.Write($"Do you want to Create a [B]ook or a [M]ovie? ");
        }

        internal static void InvalidOption()
        {
            Console.WriteLine("You selected an invalid option");
            Console.ReadLine();
        }

        internal static void LoanComplete(string name, DateTime endDate)
        {
            var outputDate = endDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"You borrowed {name}, please return it before {outputDate}, thanks!");
            Console.ReadLine();
        }

        internal static void OutOfRange()
        {
            Console.WriteLine("Your selected index number was out of range!");
            Console.ReadLine();
        }

        internal static void OutOfCopies()
        {
            Console.WriteLine("Your Item has no available copies, do you want to reserve another date?");
            Console.Write("Press enter if you do... [0] if you want to exit: ");
            
        }

        public static void ListAllItems(string item)
        {
            Header();
            Console.WriteLine($"========== List of all {item} in the database ==========\n");
        }
        public static void SelectList(string listOption)
        {
            Header();
            Console.WriteLine($"Select an option to {listOption}: ");
            Console.WriteLine("1. Books");
            Console.WriteLine("2. Movies");
            Console.WriteLine("3. Members");
        }
        
    }
}
