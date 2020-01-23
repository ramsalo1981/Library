using LibraryRepository.Models;
using System;
using System.Collections.Generic;
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
                    SelectBookById.DeleteBook();
                    break;
                case "2":
                    SelectMovieById.DeleteMovie();
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
                    PrintListsFromDB.PrintMembersList();
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
                    UpdateObjectData.UpdateBookLoan(member);
                    break;
                case "2":
                    UpdateObjectData.UpdateMovieLoan(member);
                    break;
                default:
                    StandardMessages.InvalidOption();
                    break;
            }
        }
    }
}
