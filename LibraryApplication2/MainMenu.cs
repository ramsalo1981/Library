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
                            ItemDataCapture.Item("an Item");
                            break;
                        case "2":
                            MemberDataCapture.CreateMember();
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
                            CommonSwitches.PrintAnyList();
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
}