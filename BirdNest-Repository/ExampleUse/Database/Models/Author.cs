using BirdNest.BaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUse.Database.Models
{
    class Author : IId, IName
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

namespace ExampleUse.Database.Models.Configuration {
    class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(
                new Author() { Name = "Patrick Rothfuss" },
                new Author() { Name = "Haruki Murakami" },
                new Author() { Name = "Martin Fowler" },
                new Author() { Name = "Alberto Benegas Lynch (h)" });
        }
    }
}