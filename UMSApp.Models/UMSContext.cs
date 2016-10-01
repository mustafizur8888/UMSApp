using System.Collections.Generic;
using System.Data.Entity;

namespace UMSApp.Models
{
    public class UMSContext : DbContext
    {
       
        public UMSContext(): base("UMSContext")
        {


        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}