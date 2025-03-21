using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Models.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IKEA.DAL.Persistance.Data
{
    class ApplicationDbCOntext: DbContext
    {
        public ApplicationDbCOntext(DbContextOptions options) : base(options)
        {

        }

        //public ApplicationDbCOntext(DbContextOptions<ApplicationDbCOntext> options): base(options)      
        //{

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> Departments { get; set; }
    }
}
