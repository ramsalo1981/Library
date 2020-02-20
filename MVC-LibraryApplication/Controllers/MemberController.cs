using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace MVC_LibraryApplication.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            List<Member> memberList = MemberRepository.GetMembers();
            return View(memberList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, int age)
        {
            MemberRepository.SaveMemberToDB(new Member
            {
                Name = name,
                Age = age
            });
            return Redirect("/Member");
        }

        public IActionResult Delete(string id)
        {
            ObjectId memberId = new ObjectId(id);

            Member member = MemberRepository.GetMemberById(memberId);

            return View(member);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            ObjectId memberid = new ObjectId(id);

            MemberRepository.DeleteMember(memberid);

            return Redirect("/Member");
        }

        public IActionResult Edit(string id)
        {
            ObjectId memberId = new ObjectId(id);

            Member member = MemberRepository.GetMemberById(memberId);

            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(string id, string name, int age)
        {
            ObjectId memberId = new ObjectId(id);

            MemberRepository.UpdateMember(memberId, name, age);

            return Redirect("/Member");
        }
    }
}