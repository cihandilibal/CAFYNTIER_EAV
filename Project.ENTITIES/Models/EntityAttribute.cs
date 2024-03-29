﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EntityAttribute : BaseEntity
    {
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public int? ProductID { get; set; }

        //Relational Properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
        public virtual Product Product { get; set; }
    }
}
