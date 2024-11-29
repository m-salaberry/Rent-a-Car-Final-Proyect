using DAL;
using Entity;
using Entity.model;
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
                    if (ListAllInsurances().Any(i => i.TypeOfInsurance == insurance.TypeOfInsurance))
                    {
                        throw new Exception("El seguro ya existe");
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
                using (var trx = new TransactionScope())
                {
                    if (!ListAllInsurances().Any(i => i.Id == insurance.Id))
                    {
                        throw new Exception("El ID no corresponde a un seguro existente.");
                    }
                    if (insurance.Price < 0)
                    {
                        throw new Exception("El precio debe ser mayor a 0");
                    }
                    insuranceData.ModInsurance(insurance);
                    trx.Complete();
                }
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
                using (var trx = new TransactionScope())
                {
                    if (!ListAllInsurances().Any(i => i.Id == id))
                    {
                        throw new Exception("El ID no corresponde a un seguro existente.");
                    }
                    insuranceData.DeleteInsurance(id);
                    trx.Complete();

                }
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

        public InsuranceEntity GetInsuranceById(int id)
        {
            try
            {
                InsuranceEntity insurance = insuranceData.GetInsuranceById(id);
                if (insurance == null)
                {
                    throw new Exception("No se encontró el seguro");
                }
                return insurance;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}