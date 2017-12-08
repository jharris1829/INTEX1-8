using NWCustomer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NWCustomer.DAL
{
    public class PotentialsContext : DbContext
    {
        public PotentialsContext() : base("PotentialsContext")
        {

        }

        public DbSet<Potential> Potential { get; set; }
        public DbSet<WorkOrders> WorkOrders { get; set; }
        public DbSet<Compounds> Compounds { get; set; }
        public DbSet<Samples> Samples { get; set; }
        public DbSet<testTube> testTube { get; set; }
        public DbSet<Serialized_Tests> Serialized_Tests { get; set; }
        public DbSet<Assays> Assays { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<CustomerAccount> CustomerAccount { get; set; }
    }
}