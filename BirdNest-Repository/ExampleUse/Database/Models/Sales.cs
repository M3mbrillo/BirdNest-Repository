using BirdNest.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUse.Database.Models
{
    class Sales : IId
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
