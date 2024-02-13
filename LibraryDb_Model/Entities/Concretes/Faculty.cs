﻿using LibraryDb_Model.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDb_Model.Entities.Concretes
{
    public class Faculty :  BaseEntity
    {

        public string Name { get; set; }


        public virtual ICollection<Group>? Groups { get; set; }

    }
}
