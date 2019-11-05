using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Book
    {

        private String title;
        private String author;
        private DateTime timeBorrowed;
        private DateTime timeReturn;

        public Book(string title, string author, DateTime timeBorrowed)
        {
            this.title = title;
            this.author = author;
            this.timeBorrowed = timeBorrowed;

            timeReturn = timeBorrowed.AddDays(14.0);
        }

        public void SetTimeReturn(DateTime newDateTime)
        {
            this.timeReturn = newDateTime;
        }

        public DateTime GetTimeReturn()
        {
            return timeReturn;
        }

        public DateTime GetTimeBorrowed()
        {
            return timeBorrowed;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetTitle()
        {
            return title;
        }


    }
}
