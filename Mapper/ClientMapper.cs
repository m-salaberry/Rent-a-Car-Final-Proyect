using Entity;
using Entity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class ClientMapper
    {

        public static ClientEntity Map(Client client)
        {
            try
            {
                return new ClientEntity
                {
                    Dni = client.Dni,
                    Name = client.Name,
                    Surname = client.Surname,
                    LicenseValidDate = client.LicenseValidDate,
                    QuantityOfRents = client.QuantityOfRents,
                    BlackList = client.BlackList
                };
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static Client Map(ClientEntity client)
        {
            try
            {
                return new Client
                {
                    Dni = client.Dni,
                    Name = client.Name,
                    Surname = client.Surname,
                    LicenseValidDate = client.LicenseValidDate,
                    QuantityOfRents = client.QuantityOfRents,
                    BlackList = client.BlackList
                };
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
}
