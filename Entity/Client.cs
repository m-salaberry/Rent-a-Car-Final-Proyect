using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {

        private int dni;
        private string name;
        private string surname;
        private string licenseValidDate;
        private int quantityOfRents;
        private bool blackList;

        public int Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string LicenseValidDate { get => licenseValidDate; set => licenseValidDate = value; }
        public int QuantityOfRents { get => quantityOfRents; set => quantityOfRents = value; }
        public bool BlackList { get => blackList; set => blackList = value; }
    }
}
