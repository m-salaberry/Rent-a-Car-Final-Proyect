using Entity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RentEntity
    {

        private int id;
        private ClientEntity client;
        private CarEntity car;
        private InsuranceEntity insurance;
        private DateTime rentDate;
        private DateTime returnDate;
        private double finalPrice;
        private int creditCardNum;

        public int Id { get => id; set => id = value; }
        public ClientEntity Client { get => client; set => client = value; }
        public CarEntity Car { get => Car; set => Car = value; }
        public InsuranceEntity Insurance { get => insurance; set => insurance = value; }
        public DateTime RentDate { get => rentDate; set => rentDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public double FinalPrice { get => finalPrice; set => finalPrice = value; }
        public int CreditCardNum { get => creditCardNum; set => creditCardNum = value; }
    }
}
