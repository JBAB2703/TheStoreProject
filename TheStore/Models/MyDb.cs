using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheStore.Models {

    public class MyDb : DbContext 
        {
        public int MyProperty { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors{ get; set; }

        public MyDb(DbContextOptions options) : base(options) { }

        }
}
