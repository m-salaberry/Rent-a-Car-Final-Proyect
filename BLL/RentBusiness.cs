using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RentBusiness
    {
        RentData rentData = new RentData();
        public void AddRent(RentEntity rent)
        {
            try
            {
                if (rent.Car == null)
                {
                    throw new Exception("El auto cargado no es valido");
                }
                if (rent.Client == null)
                {
                    throw new Exception("El cliente cargado no es valido");
                }
                if (rent.Insurance == null)
                {
                    throw new Exception("El seguro cargado no es valido");
                }
                if (rent.RentDate == null)
                {
                    throw new Exception("La fecha de alquiler no es valida");
                }
                if (rent.ReturnDate == null)
                {
                    throw new Exception("La fecha de devolucion no es valida");
                }
                if (rent.FinalPrice < 0)
                {
                    throw new Exception("El precio final no es valido");
                }
                if (rent.RentDate < DateTime.Today)
                {
                    throw new Exception("La fecha de inicio de la renta no puede ser previo al dia de la fecha");
                }
                if (rent.ReturnDate < rent.RentDate)
                {
                    throw new Exception("La fecha de finalizacion de la renta no puede ser previo a la fecha de inicio");
                }
                using(var trx = new System.Transactions.TransactionScope())
                {
                    rentData.AddRent(rent);
                    trx.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RentEntity> GetAllRents()
        {
            try
            {
                return rentData.ListAllRents();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
