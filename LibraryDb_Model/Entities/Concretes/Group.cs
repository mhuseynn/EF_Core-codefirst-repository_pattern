using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }


        public int FacultyId { get; set; }


        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}
