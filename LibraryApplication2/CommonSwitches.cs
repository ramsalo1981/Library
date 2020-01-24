using LibraryRepository.Models;
using CommonClasses;
using System;
using System.Text;

namespace LibraryApplication2
{
    class CommonSwitches
    {
        public static void DeleteSwitch()
        {
            StandardMessages.SelectList("Delete");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DeleteItem.DeleteBook();
                    break;
                case "2":
                    DeleteItem.DeleteMovie();
                    break;
                case "3":
                    SelectMemberById.DeleteMember();
                    break;
                default:
                    StandardMessages.InvalidOption();
                    break;
            }

        }

        public static void PrintAnyList()
        {
            StandardMessages.SelectList("List");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    PrintListsFromDB.PrintBooksList();
                    break;
                case "2":
                    PrintListsFromDB.PrintMoviesList();
                    break;
                case "3":
                    PrintMembersFromDB.PrintMembersList();
                    break;
                default:
                    StandardMessages.InvalidOption();
                    break;
            }
        }
        public static void ReturnItem(Member member)
        {
            StandardMessages.SelectItem("return");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CommonClasses.ReturnItem.UpdateBookLoan(member);
                    break;
                case "2":
                    CommonClasses.ReturnItem.UpdateMovieLoan(member);
                    break;
                default:
                    StandardMessages.InvalidOption();
                    break;
            }
        }
        public static void UpdateSwitch()
        {
            StandardMessages.SelectList("Update");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    UpdateObjectData.UpdateBook();
                    break;
                case "2":
                    UpdateObjectData.UpdateMovie();
                    break;
                case "3":
                    UpdateObjectData.UpdateMember();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
