using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Award
    {
        public int Id { get; set; }
        public User Giver  { get; set; }
        public User Getter { get; set; }
        public string Date { get; set; }
        public int Points { get; set; }
        public int CategoryId { get; set; }
        //public DateTime NewDate { get; set; }
        //public List<Like> Likes { get; set; }
        //public List<Comment> Comments { get; set; }
        public Category Category { get; set; }

    }
}
