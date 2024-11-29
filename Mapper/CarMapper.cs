using Entity;
using Entity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CarMapper
    {

        public static CarEntity Map(Car car)
        {
            try
            {
                return new CarEntity
                {
                    Plate = car.plate,
                    Brand = car.brand,
                    Model = car.model,
                    PricePerDay = car.pricePerDay,
                    Year = car.year,
                    Kilometers = car.kilometers,
                    Color = car.color,
                    Details = car.details
                };
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static Car Map(CarEntity car)
        {
            try
            {
                return new Car
                {
                    plate = car.Plate,
                    brand = car.Brand,
                    model = car.Model,
                    pricePerDay = car.PricePerDay,
                    year = car.Year,
                    kilometers = car.Kilometers,
                    color = car.Color,
                    details = car.Details
                };
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
}
