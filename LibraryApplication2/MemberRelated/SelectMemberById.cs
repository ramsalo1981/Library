using System;
using System.Collections.Generic;
using System.Text;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using CommonClasses;

namespace LibraryApplication2
{
    class SelectMemberById
    {
        public static Member SelectMember(string option)
        {
            List<Member> members = MemberRepository.GetMembers();
            CommonClasses.StandardMessages.ListAllItems("members");
            CommonClasses.StandardMessages.ChooseMemberOptions(option);

            int i = 1;
            foreach (Member member in members)
            {
                Console.WriteLine($"{i} {member.Name} {member.Age}");
                i++;
            }

            StandardMessages.SelectMemberToDelete();
            string input = Console.ReadLine();
            int.TryParse(input, out int indexSelected);

            bool isValid = Validations.SelectedIndex(indexSelected, i, members.Count);
            if (isValid)
            {
                return members[indexSelected - 1];
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// the user gets to select a member by index and delete it
        /// </summary>
        public static void DeleteMember()
        {
            Member member = SelectMember("delete");
            if (member != null)
            {
                MemberRepository.DeleteMember(member.Id);
                StandardMessages.DeletedMessage("member");
            }
        }
    }
}
