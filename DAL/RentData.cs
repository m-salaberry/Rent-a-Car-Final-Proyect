﻿using Entity;
using Entity.model;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RentData
    {

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
                        return appDbContext.Rents.Include(a => a.Car).Include(a => a.Client).Include(a => a.Insurance).Select (a => RentMapper.Map(a)).ToList();
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
                    RentEntity rentToMod = appDbContext.Rents
                    .Include(a => a.Car)
                    .Include(a => a.Client)
                    .Include(a => a.Insurance)
                    .Where(a => a.Id == idToFind) // Filtro basado en el ID
                    .Select(a => RentMapper.Map(a))
                    .FirstOrDefault()!;

                    if (rentToMod == null)
                    {
                        return null!;
                    }

                    return rentToMod;
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
                    Rent rentToAdd = RentMapper.Map(rent);
                    appDbContext.Entry(rentToAdd.Car).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                    appDbContext.Entry(rentToAdd.Client).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                    appDbContext.Entry(rentToAdd.Insurance).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
                    appDbContext.Rents.Add(rentToAdd);
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

        public void DeleteRent(RentEntity rent)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Rent rentDb = appDbContext.Rents.Find(rent)!;
                    appDbContext.Rents.Remove(rentDb);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RentEntity> GetRentsByPlate(string plateToFind)
        {
            try
            {
                using(AppDbContext appDbContext = getAppDbContext()) {
                    List<RentEntity> rentas = appDbContext.Rents
                    .Include(a => a.Car)
                    .Include(a => a.Client)
                    .Include(a => a.Insurance)
                    .Where(a => a.Car.plate == plateToFind) // Filtro basado en la placa
                    .Select(a => RentMapper.Map(a))
                    .ToList();

                    if (rentas == null)
                    {
                        return null!;
                    }

                    return rentas;
                }   
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
