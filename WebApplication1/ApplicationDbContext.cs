using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;


namespace WebApplication1
{
        public class ApplicationDbContext : DbContext
        {
        public ApplicationDbContext() : base("name=company")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<EmployeeDepartment> EmployeeDepartment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}