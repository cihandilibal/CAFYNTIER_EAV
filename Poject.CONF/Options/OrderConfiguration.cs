﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poject.CONF.Options
{
    public class OrderConfiguration:BaseConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Siparişler");
        }
    }
}
