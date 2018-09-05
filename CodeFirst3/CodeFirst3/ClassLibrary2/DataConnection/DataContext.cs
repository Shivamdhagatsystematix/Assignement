using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.Entity;
using ClassLibrary2.Entity.Customer;
using ClassLibrary2.DataConnection;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ClassLibrary2.DataConnection
{
  
        public class DataContext : DbContext
        {
            public DataContext() : base("DefaultConnection") { }

            public DbSet<Customer_PersonalDetail> Customer_PersonalDetail { get; set; }
            public DbSet<Users> Users { get; set; }

        }
    }