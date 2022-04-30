using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Member(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }

    }
}
