using Demo.DataAccess.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Data.Contexts
{
    public class ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : DbContext(options)
    {
        /// <summary>
        //not used primary Constructor
        //public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : base(options)
        //{
        //} 
        
        /// </summary>
       

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("ConectionString");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplictionDbContext).Assembly);

        }
        public DbSet<Department> Departments { get; set; }

    }
}
