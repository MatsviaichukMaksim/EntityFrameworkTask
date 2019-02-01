using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Award Award { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
    }
}
