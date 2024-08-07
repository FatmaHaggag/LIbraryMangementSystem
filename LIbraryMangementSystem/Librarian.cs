using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbraryMangementSystem
{
    internal class Librarian
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Librarian(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
