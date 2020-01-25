using System;
using System.Collections.Generic;
using System.Text;
using CommonClasses;
using LibraryRepository;
using LibraryRepository.Database;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using LibraryRepository.Factory;

namespace LibraryApplication2
{
    class MemberDataCapture
    {
        /// <summary>
        /// the user gets to enter the property values of a meber, and than gets and Member object returned
        /// </summary>
        /// <returns>a Member object</returns>
        public static Member Member()
        {
            Console.Write("Name of Member: ");
            string name = Console.ReadLine();

            Console.Write("Age of Member: ");
            string input = Console.ReadLine();
            int age = Validations.ParseInt(input);
            age = Validations.TryAgain(age);

            Member member = Factory.CreateMember(name, age);

            return member;
        }
    }
}
