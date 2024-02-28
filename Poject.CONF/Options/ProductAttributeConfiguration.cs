﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poject.CONF.Options
{
    public class ProductAttributeConfiguration:BaseConfiguration<ProductAttribute>
    {
        public ProductAttributeConfiguration()
        {
            ToTable("ÜrünÖzellikleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ProductID,
                x.AttributeID
            });
        }
    }
}
