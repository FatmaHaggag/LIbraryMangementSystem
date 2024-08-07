using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryMangementSystem
{
    internal class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id, string name)
        {
            this.Name = name;
            this.ID = id;
            this.BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (book.NumberOfCopies > 0)
            {
                book.BorrowBook();
                BorrowedBooks.Add(book);
            }
            else
            {
                throw new InvalidOperationException("No copies available to borrow.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.ReturnBook();
                BorrowedBooks.Remove(book);
            }
            else
            {
                throw new InvalidOperationException("This book was not borrowed by the member.");
            }
        }

    }
}
