﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AppUserConfiguration: BaseConfiguration<AppUser>

    {
        public AppUserConfiguration()
        {
            ToTable("Kullanıcılar");
            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);

        }
    }

}
