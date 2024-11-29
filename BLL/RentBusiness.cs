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
        public void VerificationRent(RentEntity rent)
        {
            try
            {

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
                rentData.AddRent(rent);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
