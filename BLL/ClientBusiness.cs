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
    public class ClientBusiness
    {
        ClientData clientData = new ClientData();
        public void AddCliente(ClientEntity client)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (Convert.ToString(client.Dni).Length < 7 || Convert.ToString(client.Dni).Length > 8)
                    {
                        throw new Exception("EL dni debe tener entre 7 y 8 digitos");
                    }
                    if (client.Name.Length < 3)
                    {
                        throw new Exception("El nombre debe tener como minimo 3 caracteres");
                    }
                    if (client.Surname.Length < 3)
                    {
                        throw new Exception("El apellido debe tener como minimo 2 caracteres");
                    }
                    if (client.LicenseValidDate < DateTime.Now)
                    {
                        throw new Exception("La licencia de conducir no puede estar vencida");
                    }
                    if (client.BlackList == null)
                    {
                        throw new Exception("'Habilitado' no puede estar vacio");
                    }

                    clientData.AddClient(client);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
