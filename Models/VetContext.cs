﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BW5.Models
{
    public class VetContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BW5.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public VetContext()
            : base("name=VetContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Box> Boxes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<Placement> Placements { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsUsage> ProductUsages { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Therapy> Therapies { get; set; }
        public virtual DbSet<Usage> Usages { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}