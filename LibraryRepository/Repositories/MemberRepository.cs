using LibraryRepository.Models;
using LibraryRepository.Database;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace LibraryRepository.Repositories
{
    public class MemberRepository
    {
        public static List<Member> GetMembers()
        {
            MemberHandlers mh = new MemberHandlers();
            return mh.GetMembersFromDB();
        }
        public static void DeleteMember(Member member)
        {
            MemberHandlers mh = new MemberHandlers();
            mh.DeleteMemberById(member);
        }
        public static void SaveMemberToDB(Member member)
        {
            MemberHandlers mh = new MemberHandlers();
            mh.SaveMemberToDB(member);
        }
        public static void UpdateMember(ObjectId id, string name, int age)
        {
            MemberHandlers mh = new MemberHandlers();
            mh.UpdateMember(id, name, age);
        }
    }
}
