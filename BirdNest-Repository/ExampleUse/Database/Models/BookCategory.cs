using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUse.Database.Models
{
    class BookCategory
    {
        public ICollection<Book> Books { get; set; }
        public ICollection<Category> Category { get; set; }
    }
}

namespace EF_CleanCode.Database.Configuration
{

}