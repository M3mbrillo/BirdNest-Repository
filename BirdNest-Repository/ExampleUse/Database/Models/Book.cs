using BirdNest.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleUse.Database.Models
{
    class Book : IId, IName, IDescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<BookCategory> BookCategory { get; set; }

        public IQueryable<Category> Category => this.BookCategory.SelectMany(x => x.Category).AsQueryable();
    }
}

namespace EF_CleanCode.Database.Configuration { 

}