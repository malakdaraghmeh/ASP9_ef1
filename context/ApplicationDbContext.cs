using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_ef.model;

namespace task_ef.context
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=Asp-Ef;Trusted_connection=True;TrustServerCertificate=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Department>Departments { get; set; }
    }
}
