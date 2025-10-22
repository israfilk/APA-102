using Abstraction_Overloading.Models;

namespace Abstraction_Overloading

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ebook ebook1 = new Ebook("Yeddi Gozal", "Bir sevgi macerasi ", "Nizami Gencevi", "www.ebooks.com");
            Ebook ebook2 = new Ebook("Isgendername", "Oxyucu macerasi  ", "Nizami Gencevi", "www.ebooks.com");
            Ebook ebook3 = new Ebook("Isyankar", "Men hec vaxt sizinle razi olmayacaq ", "senan", "www.ebooks.com");
            Ebook ebook4 = new Ebook("Gamer", "Her zaman oyun ", "Ferid", "www.ebooks.com");
            Ebook ebook5 = new Ebook("Firildaq", "qacis hekayesi ", "Kenan ", "www.ebooks.com");
            //ebook1.PrintBookInfo();

            bool found = false;

            Ebook[] books = { ebook1, ebook2, ebook3, ebook4, ebook5 };
            foreach (var ebook in books)
            {
                if (ebook.Author == " Gencevi")
                {
                    found = true;
                    ebook.PrintBookInfo();
                }
               


            }

            if (!found)
            {
                Console.WriteLine("yoxdu kardes");
            }


        }
    }
}
