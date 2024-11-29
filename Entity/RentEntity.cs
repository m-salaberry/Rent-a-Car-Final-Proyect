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
        private Int64 clientDni;
        private CarEntity car;
        private string carPlate;
        private InsuranceEntity insurance;
        private int insuranceId;
        private DateTime rentDate;
        private DateTime returnDate;
        private double finalPrice;

        public int Id { get => id; set => id = value; }
        public ClientEntity Client { get => client; set => client = value; }
        public Int64 ClientDni { get => client.Dni; }
        public CarEntity Car { get => car; set => car = value; }
        public string CarPlate { get => car.Plate; }
        public InsuranceEntity Insurance { get => insurance; set => insurance = value; }
        public int InsuranceId { get => insurance.Id; }
        public DateTime RentDate { get => rentDate; set => rentDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        public double FinalPrice { get => finalPrice; set => finalPrice = value; }
    }
}
