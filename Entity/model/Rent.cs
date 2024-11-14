using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.model
{
    public class Rent
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int IdClient { get; set; }

        public Client Client { get; set; }

        [ForeignKey("Car")]
        public string Plate { get; set; }

        public Car Car { get; set; }

        [ForeignKey("Insurance")]
        public int IdInsurance { get; set; }
        public Insurance Insurance { get; set; }

        [Required]
        public DateTime RentDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public double FinalPrice { get; set; }

        [Required]
        public int CreditCardNum { get; set; }


    }
}
