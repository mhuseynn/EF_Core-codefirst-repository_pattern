using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Lib : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual  ICollection<T_Card>? T_Cards { get; set; }
        public virtual ICollection<S_Card>? S_Cards { get; set; }
    }
}
