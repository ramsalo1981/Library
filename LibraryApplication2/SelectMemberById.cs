using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class SelectMemberById
    {
        public static Member SelectMember(string updateOrDelete)
        {
            Database.MemberHandlers mh = new Database.MemberHandlers();
            List<Member> members = mh.GetMembersFromDB();

            StandardMessages.ListAllItems("members");

            int i = 1;
            foreach (Member member in members)
            {
                Console.WriteLine($"{i} {member.Name} {member.Age}");
                i++;
            }

            StandardMessages.SelectItemToDelete("member", updateOrDelete);
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
        public static void DeleteMember()
        {
            Member member = SelectMember("delete");
            Database.MemberHandlers mh = new Database.MemberHandlers();
            if (member != null)
            {
                mh.DeleteMemberById(member);
                StandardMessages.DeletedMessage("member");
            }
        }
    }
}
