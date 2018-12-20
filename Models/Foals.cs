using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IrishNationalStud.Models
{
    public enum Sex
    {
        Filly, Colt
    }
    public class Foals
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public Sex Sex { get; set; }

        [Required]
        public string Colour { get; set; }

        public string Sire { get; set; }

        public string Dam { get; set; }

       
    }
}
