using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int GroupId { get; set; }


        public virtual Group Group { get; set; }

        public virtual ICollection<S_Card>? S_Cards { get; set; }

    }

}
