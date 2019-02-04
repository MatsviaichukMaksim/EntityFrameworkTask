using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Award
    {
        public int Id { get; set; }
        public int AgiverId  { get; set; } //public int GiverId  { get; set; }
        public int AgetterId { get; set; } //public int GetterId  { get; set; }
        public DateTime Date { get; set; } //
        public int Points { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        // [ForeignKey("GiverId")]
        public User Giver { get; set; }
        // [ForeignKey("GetterId")]
        public User Getter { get; set; }

    }
}
