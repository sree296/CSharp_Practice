using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserDetails
    {
        [Key]
        [Required]
        [Display(Name = "User Name")]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string userPassword { get; set; }
    }
}
