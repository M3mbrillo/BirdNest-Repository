using BirdNest.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleUse.Database.Models
{
    class Category : IId, IName, IDescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public IQueryable<Book> Books => this.BookCategories.SelectMany(x => x.Books).AsQueryable<Book>();
    }
}
