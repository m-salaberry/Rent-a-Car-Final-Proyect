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
    public class InsuranceData
    {

        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null!);
            return appDbConext;
        }

        public List<InsuranceEntity> ListAllInsurances()
        {
            try
            {
                List<InsuranceEntity> insuranceList = new List<InsuranceEntity>();

                using (AppDbContext appDbContext = getAppDbContext())
                {
                    List<Insurance> insuranceDb = appDbContext.Insurances.ToList();
                    foreach (Insurance insurance in insuranceDb)
                    {
                        insuranceList.Add(InsuranceMapper.Map(insurance));
                    }
                    return insuranceList;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddInsurance(InsuranceEntity insurance)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Insurances.Add(InsuranceMapper.Map(insurance));
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModInsurance(InsuranceEntity insurance)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Insurance insuranceDb = InsuranceMapper.Map(GetInsuranceById(insurance.Id));
                    insuranceDb.Price = insurance.Price;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteInsurance(int id)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Insurance insuranceDb = InsuranceMapper.Map(GetInsuranceById(id));
                    appDbContext.Insurances.Remove(insuranceDb);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public InsuranceEntity GetInsuranceById(int id)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Insurance insuranceDb = appDbContext.Insurances.Find(id)!;
                    if (insuranceDb == null)
                    {
                        return null!;
                    }
                    InsuranceEntity insurance = InsuranceMapper.Map(insuranceDb);
                    return insurance;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
