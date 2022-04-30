using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class MemberList
    {
        public List<Member> all = new List<Member>();

        public MemberList()
        {
            all.Add(new Member(1, "Serkan Özsöz"));
            all.Add(new Member(2, "Kazım Koyuncu"));
            all.Add(new Member(3, "Lorem Ipsum"));
            all.Add(new Member(4, "Amber Heard"));
        }

    }
}
