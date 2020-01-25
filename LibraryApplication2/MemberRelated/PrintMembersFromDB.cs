using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;

namespace LibraryApplication2
{
    public class PrintMembersFromDB
    {
        public static void PrintMembersList()
        {
            List<Member> members = MemberRepository.GetMembers();

            CommonClasses.StandardMessages.ListAllItems("members");
            foreach (Member member in members)
            {
                Console.WriteLine($"{member.Name} {member.Age}");
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
       
    }
}
