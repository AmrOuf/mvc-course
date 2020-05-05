namespace Day1
{
    using Microsoft.Ajax.Utilities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}