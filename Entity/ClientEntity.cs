using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClientEntity
    {

        private long dni;
        private string name;
        private string surname;
        private DateTime licenseValidDate;
        private int quantityOfRents;
        private bool blackList;

        public long Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime LicenseValidDate { get => licenseValidDate; set => licenseValidDate = value; }
        public int QuantityOfRents { get => quantityOfRents; set => quantityOfRents = value; }
        public bool BlackList { get => blackList; set => blackList = value; }
    }
}
