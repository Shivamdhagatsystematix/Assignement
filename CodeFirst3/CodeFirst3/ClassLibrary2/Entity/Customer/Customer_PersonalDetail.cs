using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Entity.Customer
{
    public class Customer_PersonalDetail
    {
        [Key]
        public string Id { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "City required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Contact person required")]
        [DisplayName("Contact person")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Telephone required")]
        [DisplayName("Telephone")]
        [Phone]
        public string Phone { get; set; }

        public string Role { get; set; }

        [Required(ErrorMessage = "Enter the email address")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Wrong email format")]
        [EmailAddress]
        public string Email { get; set; }

        public string Notes { get; set; }

        //Navigation properties ForeignKey
        public virtual ICollection<Users> Users { get; set; }
    }
}
