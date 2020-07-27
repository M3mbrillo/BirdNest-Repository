using System;
using System.Collections.Generic;
using System.Text;

namespace BirdNest.BaseModel
{
    // TODO Rework to a "IPK" where you can define a 
    // PK no Id int no identity
    // see how EF implement the PK definition
    public interface IId
    {
        public int Id { get; set; }

        bool IsNew() => Id == 0;
    }
}
