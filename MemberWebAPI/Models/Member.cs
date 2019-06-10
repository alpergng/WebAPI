using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberWebAPI.Models
{
    public class Member
    {
        public int Id { get; set; }
        public String Fullname { get; set; }
        public int Age { get; set; }

        public Member(int id, string fullname, int age)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Age = age;
        }

    }
}