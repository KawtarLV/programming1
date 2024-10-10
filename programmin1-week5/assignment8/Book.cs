using System;
namespace assignment8
{
    public class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            this.Author = author;
            this.Title = title;

        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"{Title} by {Author}");
           
        }
    }
}

