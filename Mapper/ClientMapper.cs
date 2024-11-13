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

        public static Client Map(ClientEntity client)
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


    }
}
