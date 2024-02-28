using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poject.CONF.Options
{
    public class CategoryConfiguration:BaseConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Kategoriler");
        }
    }
}
