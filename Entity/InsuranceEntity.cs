using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InsuranceEntity
    {

        private int id;
        private string typeOfInsurance;
        private double price;

        public int Id { get => id; set => id = value; }
        public string TypeOfInsurance { get => typeOfInsurance; set => typeOfInsurance = value; }
        public double Price { get => price; set => price = value; }
    }
}
