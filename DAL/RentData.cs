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
    public class RentData
    {
        //Delo se la come

        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null!);
            return appDbConext;
        }

        public List<RentEntity> ListAllRents()
        {
            try
            {
                List<RentEntity> rentList = new List<RentEntity>();

                using (AppDbContext appDbContext = getAppDbContext())
                {
                    List<Rent> rentDb = appDbContext.Rents.ToList();
                    foreach (Rent rent in rentDb)
                    {
                        rentList.Add(RentMapper.Map(rent));
                    }
                    return rentList;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public RentEntity GetRentById(int idToFind)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return RentMapper.Map(appDbContext.Rents.Find(idToFind)!);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddRent(RentEntity rent)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Rents.Add(RentMapper.Map(rent));
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModRent(RentEntity rentMod)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Rent rentDb = appDbContext.Rents.Find(rentMod.Id)!;
                    rentDb.Plate = rentMod.Car.Plate;
                    rentDb.IdClient = rentMod.Client.Dni;
                    rentDb.RentDate = rentMod.RentDate;
                    rentDb.ReturnDate = rentMod.ReturnDate;
                    rentDb.IdInsurance = rentMod.Insurance.Id;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteRent(int id)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Rent rentDb = appDbContext.Rents.Find(id)!;
                    appDbContext.Rents.Remove(rentDb);
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
