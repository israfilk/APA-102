using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Overloading.Models
{
    internal class Ebook : Book
    {
        public string SiteName { get; set; }
        public Ebook(string name, string author, string title, string sitename):base(name, author, title ) {
            SiteName = sitename;
        }
        
            
        

        public override void PrintBookInfo()
        {
            Console.WriteLine($"Ebook {Name}'{Titell}' by {Author} is aviable at {SiteName}");
        }
    }
}
