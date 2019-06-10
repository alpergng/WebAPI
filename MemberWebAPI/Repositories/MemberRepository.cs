using MemberWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberWebAPI.Repositories
{
    public class MemberRepository
    {
        private static Lazy<List<Member>> container = new Lazy<List<Member>>(() => Initialize(), true);

        private static List<Member> Initialize()
        {
            return new List<Member>
            {
                new Member(1,"Burak TUNGUT",22),
                new Member(2,"Gökhan GÖKALP",28)
            };
            
        }

        public static Member Add(string fullname, int age)
        {
            int lastId = container.Value.Max(m => m.Id);
            Member newMember = new Member(lastId + 1, fullname, age);
            container.Value.Add(newMember);

            return newMember;
        }

        public static List<Member> Get()
        {
            return container.Value;
        }

        public static Member Get(int id)
        {
            return container.Value.SingleOrDefault(m => m.Id == id);
        }

        public static void Remove(int id)
        {
            container.Value.Remove(Get(id));
        }

        public static void Update(Member member)
        {
            Remove(member.Id);

            container.Value.Add(member);
        }

        public static bool IsExist(int id)
        {
            return container.Value.Any(m => m.Id == id);
        }

        public static bool IsExist(String fullname)
        {
            return container.Value.Any(m => m.Fullname == fullname);
        }
    }
}