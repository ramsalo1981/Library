using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class Member
    {
        public ObjectId Id;
        public string Name { get; set; }
        public int Age { get; set; }
        public Loan Loans { get; set; }

        public Member(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
