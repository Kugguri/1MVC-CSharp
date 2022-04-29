using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCÖrnek.Models
{
    public class Customer
    {
        //public int ID { get; set; }
        [Required(ErrorMessage="Please Fill Customer Name")]
        [StringLength(50,ErrorMessage ="Please Use Max 50 Charecters for Customer Name")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddress(ErrorMessage ="Please Check Your Email Adress")]
        public string Email { get; set; }
    }
}
