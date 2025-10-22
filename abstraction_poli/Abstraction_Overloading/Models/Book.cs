using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Overloading.Models
{
    public abstract class Book
    {
        public string Name { get; set; }
        public string Titell { get; set; }

        public string Author { get; set; }

        protected Book(string name, string title, string author) {
            Name = name;
            Titell = title;
            Author = author;   
        }
        public abstract void PrintBookInfo();

        
    }
}
