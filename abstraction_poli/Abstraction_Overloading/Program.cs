using Abstraction_Overloading.Models;

namespace Abstraction_Overloading

{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Ebook ebook = new Ebook("Yeddi Gozal", "Bir sevgi macerasi ", "Nizami Gencevi", "www.ebooks.com");
            ebook.PrintBookInfo();
        }
    }
}
