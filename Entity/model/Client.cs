using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Client
    {

        [Key]
        public int Dni { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime LicenseValidDate { get; set; }

        [Required]
        public int QuantityOfRents { get; set; }

        [Required]
        public bool BlackList { get; set; }

    }
}
