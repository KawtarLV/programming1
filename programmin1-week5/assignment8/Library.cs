using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace assignment8
{
	public class Library
	{
        public Book[] books;
        public int Count;

        public Library(int capacity)
		{
			books = new Book[capacity];
            Count = 0;

		}

		public void AddBook(Book book)
		{
            if (Count < books.Length)
            {
                books[Count] = book;
                Count++;
            }
        }

        public void DisplayBooks()
        {
            for (int i = 0; i < Count; i++)
            {
              
                books[i].DisplayBookInfo();
            }
        }
    }
}

