using Remas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Remas.DAL
{
    public class RemasDbContext
    {
        public class RemasContext : DbContext
        {

            public RemasContext() : base("RemasDBContext")
            {

            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Attendence> Attendences { get; set; }
            public DbSet<Perfomance> Performences { get; set; }
            public DbSet<PerformanceStatus> PerformencesStatus { get; set; }
            public DbSet<Projects> Projects { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
        }
    }
