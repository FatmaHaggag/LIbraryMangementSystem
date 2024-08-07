using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryMangementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();


            library.AddBook(new Book("Kimetsu no yaiba", "Koyoharu Gotouge", 5));
            library.AddBook(new Book("Solo leveling", "Chugong", 3));
            library.AddBook(new Book("Atomic Habits", "James Clear", 4));

            library.AddMember(new Member(1, "amr"));
            library.AddMember(new Member(2, "ali"));

            library.AddLibrarian(new Librarian(1, "Fatma"));

            library.ListBooks();

            library.LendBook("Solo leveling".GetHashCode(), 1);
            library.LendBook("Atomic Habits".GetHashCode(), 2);

            library.ReturnBook("Solo leveling".GetHashCode(), 1);


            Console.ReadKey();
        }
    }
}
