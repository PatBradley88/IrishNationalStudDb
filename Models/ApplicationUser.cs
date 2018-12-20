using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrishNationalStud.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Staff Member")]
        public string Name { get; set; }

        [NotMapped]
        public bool IsSuperAdmin { get; set; }
    }
}
