using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class BaseConfiguration<T>: EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.CreatedDate).HasColumnName("Oluşturulma Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Güncellenme Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silinme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
