using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Library
    {
        public List<Book> ListOfBooks;

        public Library()
        {
            ListOfBooks = new List<Book>();
            ListOfBooks.Add(new Book("Poul er smuk", "Bach, Poul", new DateTime(2019, 4, 10)));
            ListOfBooks.Add(new Book("Poul er ikke smuk", "Dumrian, Spade", new DateTime(2019, 4, 11)));
            ListOfBooks.Add(new Book("Poul er altså smuk nok", "Person, Flink", new DateTime(2019, 4, 11)));
            ListOfBooks.Add(new Book("Poul er smuk: Behind the scene", "Dude, Christophpher", new DateTime(2019, 4, 11)));
            ListOfBooks.Add(new Book("Poul er ikke smuk 2", "Dumrian, Spade", new DateTime(2019, 4, 11)));
            ListOfBooks.Add(new Book("Poul er ikke smuk 3", "Dumrian, Spade", new DateTime(2019, 4, 11)));
        }

        public Book BorrowBook(string title)
        {
            for (int i = 0; i < ListOfBooks.Count; i++)
            {
                if (ListOfBooks[i].GetTitle().ToLower() == title.ToLower().Trim())
                {
                    Book bookToBorrow = ListOfBooks[i];
                    ListOfBooks.RemoveAt(i);
                    return bookToBorrow;
                }
            }
            Console.WriteLine("Book not found.");
            return null;
        }
        public Book BorrowBook(int index)
        {
            if (index >= 0 && index < ListOfBooks.Count)
            {
                Book bookToBorrow = ListOfBooks[index];
                ListOfBooks.RemoveAt(index);
                return bookToBorrow;
            }

            else
            {
                Console.WriteLine("Book not found.");
                return null;
            }
        }
        public void ReturnBook(Book book)
        {
            ListOfBooks.Add(book);
        }
    }
}
