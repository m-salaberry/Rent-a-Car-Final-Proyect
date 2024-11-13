using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Insurance
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string TypeOfInsurance { get; set; }

        [Required]
        public double Price { get; set; }

    }
}
