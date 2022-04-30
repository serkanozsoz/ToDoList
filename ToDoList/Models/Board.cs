using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            TODO.Add(new Card("Homework", "Javascript modülünü tamamla.", 1, 1));
            IN_PROGRESS.Add(new Card("Coderbyte Challenge", "C# Coderbyte Challege'ını çöz.", 2, 3));
            DONE.Add(new Card("Build", "ToDoList Projesinin build'ini al.", 3, 4));
        }
         
        public List<Card> GetProperty(string str)
        {
            if (str == "TODO")
                return this.TODO;
            else if (str == "IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }
    }
}
