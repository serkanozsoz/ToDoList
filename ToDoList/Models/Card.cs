using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public int Size { get; set; }
        public Card(string title, string content, int id, int size)
        {
            Title = title;
            Content = content;
            Id = id;
            Size = size;
        }
    }
}
