using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryMangementSystem
{
    internal class Library
    {
        private List<Book> books;
        private List<Member> members;
        private List<Librarian> librarians;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            librarians = new List<Librarian>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book.Title}");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member added: {member.Name}");
        }

        public void AddLibrarian(Librarian librarian)
        {
            librarians.Add(librarian);
            Console.WriteLine($"Librarian added: {librarian.Name}");
        }

        public void LendBook(int bookId, int memberId)
        {
            Book book = books.Find(b => b.Title.GetHashCode() == bookId);
            Member member = members.Find(m => m.ID == memberId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            try
            {
                member.BorrowBook(book);
                Console.WriteLine($"Book '{book.Title}' lent to member '{member.Name}'.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReturnBook(int bookId, int memberId)
        {
            Book book = books.Find(b => b.Title.GetHashCode() == bookId);
            Member member = members.Find(m => m.ID == memberId);

            if (book == null || member == null)
            {
                Console.WriteLine("Invalid return operation.");
                return;
            }

            try
            {
                member.ReturnBook(book);
                Console.WriteLine($"Book '{book.Title}' returned by member '{member.Name}'.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListBooks()
        {
            Console.WriteLine("Books in library:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
