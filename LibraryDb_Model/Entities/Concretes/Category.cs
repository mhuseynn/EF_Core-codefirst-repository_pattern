using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
       



        // Navigation Property
        public virtual ICollection<Book>? Books { get; set; }
    }

}
