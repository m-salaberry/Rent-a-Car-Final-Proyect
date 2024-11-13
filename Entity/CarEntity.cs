using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CarEntity
    {

        private string plate;
        private string brand;
        private string model;
        private double pricePerDay;
        private int year;
        private int kilometers;
        private string color;
        private string details;

        public string Plate { get => plate; set => plate = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public double PricePerDay { get => pricePerDay; set => pricePerDay = value; }
        public int Year { get => year; set => year = value; }
        public int Kilometers { get => kilometers; set => kilometers = value; }
        public string Color { get => color; set => color = value; }
        public string Details { get => details; set => details = value; }
    }
}
