using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryMangementSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfCopies { get; set; }
        public Book(string title, string author, int numberOfCopies)
        {
            this.Title = title;
            this.Author = author;
            this.NumberOfCopies = numberOfCopies;
        }

        public void BorrowBook()
        {
            if (NumberOfCopies > 0)
            {
                NumberOfCopies--;
            }
            else
            {
                throw new InvalidOperationException("No copies available to borrow.");
            }
        }

        public void ReturnBook()
        {
            NumberOfCopies++;
        }
    }
}
