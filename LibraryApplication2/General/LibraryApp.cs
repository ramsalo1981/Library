using CommonClasses;
using LibraryRepository.Models;
using System;

namespace LibraryApplication2
{
    public partial class LibraryApp
    {
        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                PrintMainMenu();
                string mainMenuChoice = Console.ReadLine();
                switch (mainMenuChoice)
                {
                    case "1":
                        MenuSwitches.CreateSwitch();
                        break;
                    case "2":
                        MenuOptions.CreateMember();
                        break;
                    case "3":
                        MenuSwitches.DeleteSwitch();
                        break;
                    case "4":
                        MenuSwitches.UpdateSwitch();
                        break;
                    case "5":
                        MenuOptions.BorrowBookMenu();
                        break;
                    case "6":
                        MenuOptions.BorrowMovieMenu();
                        break;
                    case "7":
                        MenuOptions.ReturnItemMenu();
                        break;
                    case "8":
                        MenuSwitches.PrintAnyList();
                        break;
                    case "9":

                        break;
                    case "10":

                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

        }
        private void PrintMainMenu()
        {
            StandardMessages.Header();
            Console.WriteLine("[1] Create New Item");
            Console.WriteLine("[2] Create New Member");
            Console.WriteLine("[3] Delete from Database");
            Console.WriteLine("[4] Update in Database");
            Console.WriteLine("[5] Borrow a Book");
            Console.WriteLine("[6] Borrow a Movie");
            Console.WriteLine("[7] Return Item");
            Console.WriteLine("[8] All lists in Database");
            //Console.WriteLine("[9] ");
            Console.WriteLine("[0] Exit");
        }
        

    }
}