using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.model;

namespace Mapper
{
    public class RentMapper
    {

        public static RentEntity Map(Rent rent)
        {
            try
            {
                return new RentEntity
                {
                    Id = rent.Id,
                    Car = CarMapper.Map(rent.Car),
                    Client = ClientMapper.Map(rent.Client),
                    Insurance = InsuranceMapper.Map(rent.Insurance),
                    RentDate = rent.RentDate,
                    ReturnDate = rent.ReturnDate,
                    FinalPrice = rent.FinalPrice
                };
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static Rent Map(RentEntity rent)
        {
            try
            {
                return new Rent
                {
                    Id = rent.Id,
                    Car = CarMapper.Map(rent.Car),
                    Client = ClientMapper.Map(rent.Client),
                    Insurance = InsuranceMapper.Map(rent.Insurance),
                    RentDate = rent.RentDate,
                    ReturnDate = rent.ReturnDate,
                    FinalPrice = rent.FinalPrice
                };
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
