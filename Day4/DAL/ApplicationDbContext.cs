namespace Day1.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

       
        public virtual DbSet<Employee> Employees { get; set; }
    }


}