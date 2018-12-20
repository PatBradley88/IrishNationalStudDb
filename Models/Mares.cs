using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IrishNationalStud.Models
{
    public class Mares
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Sire { get; set; }
        [Required]
        public string Dam { get; set; }

        [Required]
        public string Colour { get; set; }
        

        public bool InFoal { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public string Foal { get; set; }
       
        public string Stallions { get; set; }
    }
}
