using Entity.model;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace DAL
{
    public class ClientData
    {

        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null!);
            return appDbConext;
        }

        public List<ClientEntity> ListAllClients()
        {
            try
            {
                List<ClientEntity> clientList = new List<ClientEntity>();

                using (AppDbContext appDbContext = getAppDbContext())
                {
                    List<Client> clientDb = appDbContext.Clients.ToList();
                    foreach (Client client in clientDb)
                    {
                        clientList.Add(ClientMapper.Map(client));
                    }
                    return clientList;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClientEntity GetClientByDni(int dniToFind)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return ClientMapper.Map(appDbContext.Clients.Find(dniToFind)!);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddClient(ClientEntity client)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Clients.Add(ClientMapper.Map(client));
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModClient(ClientEntity clientMod)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    Client client = appDbContext.Clients.Find(clientMod.Dni)!;
                    client.Name = clientMod.Name;
                    client.Surname = clientMod.Surname;
                    client.LicenseValidDate = clientMod.LicenseValidDate;
                    client.QuantityOfRents = clientMod.QuantityOfRents;
                    client.BlackList = clientMod.BlackList;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteClient(int dniToDelete)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    appDbContext.Clients.Remove(appDbContext.Clients.Find(dniToDelete)!);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsClientBlackListed(int dniToCheck)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return appDbContext.Clients.Find(dniToCheck)!.BlackList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsLicenseValid(int dniToCheck)
        {
            try
            {
                using (AppDbContext appDbContext = getAppDbContext())
                {
                    return appDbContext.Clients.Find(dniToCheck)!.LicenseValidDate > DateTime.Now;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
