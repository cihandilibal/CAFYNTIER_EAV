﻿using Project.CONF.Options;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
	public class MyContext : DbContext
	{
		public MyContext() : base("Ahmet")
		{
			
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AppUserConfiguration());
			modelBuilder.Configurations.Add(new ProfileConfiguration());
			modelBuilder.Configurations.Add(new CategoryConfiguration());
			modelBuilder.Configurations.Add(new ProductConfiguration());
			modelBuilder.Configurations.Add(new OrderConfiguration());
			modelBuilder.Configurations.Add(new OrderDetailConfiguration());
			modelBuilder.Configurations.Add(new EntityAttributeConfiguration());
			modelBuilder.Configurations.Add(new ProductAttributeConfiguration());
		}

        public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<EntityAttribute> EntityAttributes { get; set; }
		public DbSet<ProductAttribute> ProductAttributes { get; set; }

	}
}
