using System;

namespace LibraryApplication2
{
    public partial class LibraryApp
    {
        public class MainMenu
        {
            public void MainChoiceMenu()
            {
                bool exit = false;
                while (!exit)
                {
                    PrintMainMenu();
                    string mainMenuChoice = Console.ReadLine();
                    switch (mainMenuChoice)
                    {
                        case "1":
                            ObjectDataCapture.Item("an Item");
                            break;
                        case "2":
                            ObjectDataCapture.CreateMember();
                            break;
                        case "3":
                            CommonSwitches.DeleteSwitch();
                            break;
                        case "4":
                            UpdateObjectData.UpdateSwitch();
                            break;
                        case "5":
                            LoanProcess.BorrowABook();
                            break;
                        case "6":
                            LoanProcess.BorrowAMovie();
                            break;
                        case "7":
                            CommonSwitches.ReturnItem();
                            break;
                        case "8":
                            break;
                        case "9":
                            CommonSwitches.PrintAnyList();
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
                Console.WriteLine("[8] ");
                Console.WriteLine("[9] All lists in Database");
                Console.WriteLine("[0] Exit");
            }
        }
    }
}