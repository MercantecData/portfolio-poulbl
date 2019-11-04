using System;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Library Lib = new Library();


            Console.WriteLine("OG list");
            for (int i = 0; i < Lib.ListOfBooks.Count; i++)
            {
                Console.WriteLine(Lib.ListOfBooks[i].title); 
            }

            Book borrowedBook = Lib.BorrowBook("Poul er Smuk");
            Console.WriteLine(borrowedBook.author);


            Console.WriteLine("Post borrow");
            for (int i = 0; i < Lib.ListOfBooks.Count; ++i)
            {
                Console.WriteLine(Lib.ListOfBooks[i].title);
            }

            Console.WriteLine(borrowedBook.timeReturn);
            borrowedBook.setTimeReturn(new DateTime(2020, 4, 20));
            Console.WriteLine(borrowedBook.timeReturn);

            Lib.ReturnBook(borrowedBook);
            Console.WriteLine("Post return");
            for (int i = 0; i < Lib.ListOfBooks.Count; ++i)
            {
                Console.WriteLine(Lib.ListOfBooks[i].title);
            }

        }
    }
}