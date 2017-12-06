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
    }
}