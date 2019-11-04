using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Book
    {

        public String title;
        public String author;
        public DateTime timeBorrowed;
        public DateTime timeReturn;

        public Book(string title, string author, DateTime timeBorrowed)
        {
            this.title = title;
            this.author = author;
            this.timeBorrowed = timeBorrowed;

            timeReturn = timeBorrowed.AddDays(14.0);
        }

        public void setTimeReturn(DateTime newDateTime)
        {
            this.timeReturn = newDateTime;
        }


    }
}
