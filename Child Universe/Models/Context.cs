using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Child_Universe.Models
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection") { }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
    }
}