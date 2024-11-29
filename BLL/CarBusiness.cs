using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class CarBusiness
    {

        CarData carData = new CarData();

        public void AddCar(CarEntity car)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (car.Plate.Length < 6 || car.Plate.Length > 7)
                    {
                        throw new Exception("La patente debe tener entre 6 y 7 caracteres");
                    }
                    if (car.PricePerDay <= 0)
                    {
                        throw new Exception("El precio por día debe ser mayor a $0");
                    }
                    if (car.Details.Length < 5)
                    {
                        throw new Exception("Debe ingresar detalles correctamente, superando los 5 caracteres");
                    }
                    if (car.Model.Length < 4)
                    {
                        throw new Exception("El nombre del modelo debe tener un mínimo de 4 caracteres");
                    }
                    if (car.Brand.Length < 3)
                    {
                        throw new Exception("EL nombre de la marca debe tener un mínimo de 3 caracteres");
                    }
                    if (car.Year >= DateTime.Now.Year)
                    {
                        throw new Exception("El año del auto debe ser menor al año actual");
                    }
                    if (Convert.ToString(car.Year).Length < 4)
                    {
                        throw new Exception("EL año debe tener como mínimo 4 digitos");
                    }
                    if (car.Color.Length < 4)
                    {
                        throw new Exception("El color debe tener como mínimo 4 caracteres");
                    }
                    if (car.Kilometers < 0)
                    {
                        throw new Exception("Los kilómetros del auto deben ser mayor a 0");
                    }

                    carData.AddCar(car);
                    trx.Complete();
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
                CarEntity car = new CarEntity();
                car = carData.GetCarByPlate(carMod.Plate);

                if (car.Plate.Length < 6 || car.Plate.Length > 7) { throw new Exception("La patente debe tener entre 6 y 7 caracteres"); }
                if (car.PricePerDay <= 0) { throw new Exception("El precio por día debe ser mayor a $0"); }
                if (car.Details.Length < 5) { throw new Exception("Debe ingresar detalles correctamente, superando los 5 caracteres"); }
                if (car.Kilometers < 0) { throw new Exception("Los kilómetros del auto deben ser mayor a 0"); }

                using (var trx = new TransactionScope())
                {
                    carData.ModCar(carMod);
                    trx.Complete();
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
                CarEntity carEntity = new CarEntity();
                carEntity = carData.GetCarByPlate(plateToDelete);
                if (carEntity == null) 
                { 
                    throw new Exception("No se encontró la patente a eliminar"); 
                }

                using (var trx = new TransactionScope())
                {
                    carData.DeleteCar(plateToDelete);
                    trx.Complete();
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
                if (plateToFind == null)
                {
                    throw new Exception("La patente no puede ser nula");
                }
                CarEntity carMod = carData.GetCarByPlate(plateToFind);
                if (carMod == null)
                {
                    throw new Exception("No se encontró la patente");
                }
                return carMod;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CarEntity> GetAllCars()
        {
            try
            {
                return carData.ListAllCars();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}

