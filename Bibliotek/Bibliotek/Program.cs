using System;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Library Lib = new Library();



            Console.WriteLine("\n\n Oprindelig list");
            for (int i = 0; i < Lib.ListOfBooks.Count; i++)
            {
                Console.WriteLine(Lib.ListOfBooks[i].GetTitle()); 
            }

            Book borrowedBook = Lib.BorrowBook("Poul er Smuk");
            Console.WriteLine(borrowedBook.GetAuthor());


            Console.WriteLine("\n\nPost borrow");
            for (int i = 0; i < Lib.ListOfBooks.Count; ++i)
            {
                Console.WriteLine(Lib.ListOfBooks[i].GetTitle());
            }

            Console.WriteLine(borrowedBook.GetTimeReturn());
            borrowedBook.SetTimeReturn(new DateTime(2020, 4, 20));
            Console.WriteLine(borrowedBook.GetTimeReturn());

            Lib.ReturnBook(borrowedBook);
            Console.WriteLine("\n\nPost return");
            for (int i = 0; i < Lib.ListOfBooks.Count; ++i)
            {
                Console.WriteLine(Lib.ListOfBooks[i].GetTitle());
            }


            Book borrowBook;
            Console.WriteLine("\n\n\n Borrow book index test at 0: ");
            borrowBook = Lib.BorrowBook(0);
            Console.WriteLine("\n Borrow book index test at 5000: ");
            borrowBook = Lib.BorrowBook(5000);
            Console.WriteLine("\n Borrow book index test at -1: ");
            borrowBook = Lib.BorrowBook(-1);

        }
    }
}