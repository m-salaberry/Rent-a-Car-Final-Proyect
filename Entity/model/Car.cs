using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Car
    {

        [Key]
        public string plate { get; set; }

        [Required]
        public string brand { get; set; }

        [Required]
        public string model { get; set; }

        [Required]
        public double pricePerDay { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public int kilometers { get; set; }

        [Required]
        public string color { get; set; }

        [Required]
        public string details { get; set; }


    }
}
