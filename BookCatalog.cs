using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class BookCatalog
    {
        private LinkedList<Book> books = new LinkedList<Book>();
        public void AddBook(Book book)
        {
            books.AddLast(book);
        }
        public void AddToStart(Book book)
        {
            books.AddFirst(book);
        }
        public void AddAtPosition(Book book, int position)
        {
            if (position < 0 || position > books.Count)
            {
                Console.WriteLine("Error");
                return;
            }

            if (position == 0)
            {
                books.AddFirst(book);
                return;
            }

            var current = books.First;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.Next;
            }
            books.AddAfter(current, book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void RemoveFromStart()
        {
            if (books.Count > 0)
            {
                books.RemoveFirst();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void RemoveFromEnd()
        {
            if (books.Count > 0)
            {
                books.RemoveLast();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void RemoveAtPosition(int position)
        {
            if (position < 0 || position >= books.Count)
            {
                Console.WriteLine("Error");
                return;
            }

            var current = books.First;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
            }
            books.Remove(current);
        }
        public void Update(string t, Book newBook)
        {
            bool found = false;
            foreach (var book in books)
            {
                if (book.Title == t)
                {
                    Console.WriteLine("Книга найдена");
                    book.Title = newBook.Title;
                    book.Author = newBook.Author;
                    book.Year = newBook.Year;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Книга не найдена.");
            }

        }
        public void Print()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
    }
}
