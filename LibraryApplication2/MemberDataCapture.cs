using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class MemberDataCapture
    {
        public static void CreateMember()
        {
            StandardMessages.CreateMessage("a Member");
            Console.Write("Name of Member: ");
            string name = Console.ReadLine();

            Console.Write("Age of Member: ");
            string input = Console.ReadLine();
            int age = Validations.ParseInt(input);
            age = Validations.TryAgain(age);

            Member member = new Member(name, age);
            Database.MemberHandlers mh = new Database.MemberHandlers();

            mh.SaveMemberToDB(member);
            StandardMessages.WasCreatedMessage("member");

        }
    }
}
