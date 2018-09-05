using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using ClassLibrary2.Entity.Customer;

namespace ClassLibrary2.Entity
{
    public class Users
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        //Foreign key for Customer_PersonalDetail

        [Required]
        public int Id { get; set; }

        //Navigation properties
        public virtual Customer_PersonalDetail Customer_PersonalDetail { get; set; }
    }
}

