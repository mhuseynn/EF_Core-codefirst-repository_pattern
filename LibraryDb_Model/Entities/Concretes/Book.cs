using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
       
        public int? Pages { get; set; }

        public DateTime YearPress { get; set; }

        public string Comment { get; set; }

        public int Quantity { get; set; }

        // Foreign Key
        public int? CategoryId { get; set; }

        public int  AuthorId { get; set; }


        public int PresId { get; set; }

        public int ThemeId { get; set; }

        //Navigation Property
        
        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }

        public virtual Pres Pres { get; set; }

        public virtual Theme Theme { get; set; }

        public virtual ICollection<T_Card>? T_Cards { get; set; }

        public virtual ICollection<S_Card>? S_Cards { get; set; }
    }
}
