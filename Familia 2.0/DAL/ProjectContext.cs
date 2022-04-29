using Familia_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Familia_2._0.DAL
{
    public class ProjectContext : IdentityDbContext<ApplicationUser>
    {
        public ProjectContext()
            : base("ProjectContext", throwIfV1Schema: false)
        {
        }

        public static ProjectContext Create()
        {
            return new ProjectContext();
        }

        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}