using System;
namespace assignment4
{
	public class Book
	{
		public string Title;
		public string Author;

		public Book(string Title,string Author)
		{
			this.Author = Author;
			this.Title = Title;

        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }
}

