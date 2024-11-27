using Entity;
using Entity.model;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarData
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null!);
            return appDbConext;
        }
        public List<CarEntity> ListAllCars() 
        {
			try
			{
				List<CarEntity> carList = new List<CarEntity>();

                using(AppDbContext appDbContext = getAppDbContext())
                {
                    List<Car> carsDb = appDbContext.Cars.ToList();
                    foreach (Car car in carsDb)
                    {
                        carList.Add(CarMapper.Map(car));
                    }
                    return carList;
                }

            }
			catch (Exception)
			{

				throw;
			}
        }

        public CarEntity GetCarByPlate(string plateToFind)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return CarMapper.Map(appDbContext.Cars.Find(plateToFind)!);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddCar(CarEntity car)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Cars.Add(CarMapper.Map(car));
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModCar(CarEntity carMod)
        {
            try
            {
                using(AppDbContext appDbContext = getAppDbContext())
                {
                    Car carToMod = appDbContext.Cars.Find(carMod.Plate)!;
                    carToMod.plate = carMod.Plate;
                    carToMod.brand = carMod.Brand;
                    carToMod.model = carMod.Model;
                    carToMod.pricePerDay = carMod.PricePerDay;
                    carToMod.year = carMod.Year;
                    carToMod.kilometers = carMod.Kilometers;
                    carToMod.color = carMod.Color;
                    carToMod.details = carMod.Details;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCar(string plateToDelete)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Cars.Remove(appDbContext.Cars.Find(plateToDelete)!);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
