using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int DepartmentId { get; set; }

        public virtual  Department Department { get; set; }
        public virtual ICollection<T_Card>? T_Cards { get; set; }
    }
}
