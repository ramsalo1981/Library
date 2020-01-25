using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
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

        public static void SelectMemberToDelete()
        {
            Console.Write($"Select a member to delete by index number or 0 to exit: ");
        
        }

        /// <summary>
        /// prints the object that was deletet in a message
        /// </summary>
        /// <param name="item">the type of object</param>
        public static void DeletedMessage(string item)
        {
            Console.WriteLine($"The {item} was deleted");
            Console.ReadLine();
        }

        /// <summary>
        /// prints the object that was created in a message
        /// </summary>
        /// <param name="item">the type of object</param>
        public static void WasCreatedMessage(string item)
        {
            Console.WriteLine($"You've created a new {item}");
            Console.ReadLine();
        }

        /// <summary>
        /// prints create header
        /// </summary>
        /// <param name="item">type of item object</param>
        public static void CreateMessage(string item)
        {
            Header();
            Console.WriteLine($"========== Create {item}! ==========");
        }

        /// <summary>
        /// prints the object that was updated in a message
        /// </summary>
        /// <param name="item">the type of object</param>
        public static void UpdatedMessage(string item)
        {
            Console.WriteLine($"Your {item} has been updated");
            Console.ReadLine();
        }

        /// <summary>
        /// prints a choose a book or a movie message
        /// </summary>
        public static void BookOrMovieMessage()
        {
            Console.Write($"Do you want to Create a [B]ook or a [M]ovie? ");
        }

        /// <summary>
        /// Lets the user select an option to print a list of
        /// </summary>
        /// <param name="listOption"></param>
        public static void SelectList(string listOption)
        {
            Header();
            Console.WriteLine($"Select an option to {listOption}: ");
            Console.WriteLine("1. Books");
            Console.WriteLine("2. Movies");
            Console.WriteLine("3. Members");
        }

        /// <summary>
        /// lets the user select an item to return
        /// </summary>
        /// <param name="listOption"></param>
        public static void SelectItem(string listOption)
        {
            Header();
            Console.WriteLine($"Select an option to {listOption}: ");
            Console.WriteLine("1. Books");
            Console.WriteLine("2. Movies");
        }
        
    }
}
