using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class OrderDetailConfiguration: BaseConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration()
        {
            ToTable("SiparişDetayları");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
