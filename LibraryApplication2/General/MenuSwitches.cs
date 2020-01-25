using LibraryRepository.Models;
using CommonClasses;
using System;
using System.Text;

namespace LibraryApplication2
{
    class MenuSwitches
    {
        public static void CreateSwitch()
        {
            StandardMessages.SelectItem("create");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    MenuOptions.CreateBook();
                    break;
                case "2":
                    MenuOptions.CreateMovie();
                    break;
                default:
                    CommonClasses.StandardMessages.InvalidOption();
                    break;
            }
        }
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
                    CommonClasses.StandardMessages.InvalidOption();
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
                    CommonClasses.StandardMessages.InvalidOption();
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
                    CommonClasses.StandardMessages.InvalidOption();
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
                    MenuOptions.UpdateBook();
                    break;
                case "2":
                    MenuOptions.UpdateMovie();
                    break;
                case "3":
                    MenuOptions.UpdateMember();
                    break;
                default:
                    CommonClasses.StandardMessages.InvalidOption();
                    break;
            }
        }
    }
}
