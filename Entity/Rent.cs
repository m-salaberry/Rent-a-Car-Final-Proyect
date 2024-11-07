using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Rent
    {

        private int id;
        private int idClient;
        private string carPlate;
        private DateTime rentDate;
        private DateTime returnDate;
        private long finalPrice;
        private int creditCardNum;

        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public string CarPlate { get => carPlate; set => carPlate = value; }
        public DateTime RentDate { get => rentDate; set => rentDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public long FinalPrice { get => finalPrice; set => finalPrice = value; }
        public int CreditCardNum { get => creditCardNum; set => creditCardNum = value; }
    }
}
