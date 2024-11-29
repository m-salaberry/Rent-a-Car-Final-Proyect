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
    public class InsuranceBusiness
    {

        InsuranceData insuranceData = new InsuranceData();

        public void AddInsurance(InsuranceEntity insurance)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (insurance.TypeOfInsurance.Length < 5)
                    {
                        throw new Exception("El nombre del seguro debe tener como minimo 5 caracteres");
                    }
                    if (insurance.Price < 0)
                    {
                        throw new Exception("El precio debe ser mayor a 0");
                    }


                    insuranceData.AddInsurance(insurance);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModInsurance(InsuranceEntity insurance)
        {
            try
            {
                insuranceData.ModInsurance(insurance);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteInsurance(int id)
        {
            try
            {
                insuranceData.DeleteInsurance(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<object> MostrarGrillaDB(List<InsuranceEntity> lista)
        {
            try
            {
                return lista.Select(insurance => new
                {
                    Id = insurance.Id,
                    TipoSeguro = insurance.TypeOfInsurance,
                    Precio = insurance.Price
                });
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public List<InsuranceEntity> ListAllInsurances()
        {
            try
            {
                return insuranceData.ListAllInsurances();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}

