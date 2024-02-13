using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class S_Card : BaseEntity
    {

        public int StudentId { get; set; }

        public int BookId { get; set; }

        public int LibId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public virtual Lib Lib { get; set; }
             
        public virtual Student Student { get; set; }
               
        public virtual Book Book { get; set; }
    }
}
