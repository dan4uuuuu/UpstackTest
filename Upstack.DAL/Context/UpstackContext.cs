using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upstack.DAL.Model;

namespace Upstack.DAL.Context
{
    public class UpstackContext : DbContext
    {
        public UpstackContext() : base("UpstackTestDB") { }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
