using System;
using System.Collections.Generic;
using LibraryApplication2;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace UserLibraryApplication
{
    internal class UserLibraryApp
    {
        Member thisMember = new Member();
        internal void Start()
        {
            ShowLoginScreen();
        }
        private void ShowLoginScreen()
        {
            bool validLoginName = false;
            while (!validLoginName)
            {
            List<Member> members = MemberRepository.GetMembers();
            Console.Write("Enter your Member name to log in: ");
            string input = Console.ReadLine();
            foreach (Member member in members)
            {
                if (input == member.Name)
                {
                    validLoginName = true;
                        thisMember = member;
                }
            }
            if (!validLoginName)
            {
                    Console.WriteLine("Invalid Member Name, please try again");
                    input = Console.ReadLine();
            }
                else
                {
                    MainMenuOptions();
                }
            }
        }
        private void MainMenuOptions()
        {
            bool exit = false;
            while (!exit)
            {
                PrintMainMenu();
                string mainMenuChoice = Console.ReadLine();
                switch (mainMenuChoice)
                {
                    case "1":
                        PrintListsFromDB.PrintBooksList();
                        break;
                    case "2":
                        LoanProcess.BorrowABook(thisMember);
                        break;
                    case "3":
                        PrintListsFromDB.PrintMoviesList();
                        break;
                    case "4":
                        LoanProcess.BorrowAMovie(thisMember);
                        break;
                    case "5":
                        UpdateObjectData.UpdateBookLoan(thisMember);
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
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
            Console.WriteLine("[1] List All Books");
            Console.WriteLine("[2] Borrow a Book");
            Console.WriteLine("[3] List All Movies");
            Console.WriteLine("[4] Borrow a Movie");
            Console.WriteLine("[5] Return Book");
            //Console.WriteLine("[6] Borrow a Movie");
            //Console.WriteLine("[7] Return Item");
            //Console.WriteLine("[8] All lists in Database");
            //Console.WriteLine("[9] ");
            Console.WriteLine("[0] Exit");
        }
    }
}