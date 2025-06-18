using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Project.Models
{
    public class ClientRepository
    {
        private static List<Client> Clients = new List<Client>();
        private static int nextId = 1;


        public static List<Client> ClientList()
        {
            return Clients;
        }

        public static Client GetById(int id)
        {
            return Clients.FirstOrDefault(c => c.Id == id); 
        }

        public static void Add(Client Client)
        {
            Client.Id = nextId++;
            Client.DateRegistration = DateTime.Now;
            Clients.Add(Client);
        }

        public static void Update(Client client)
        {
            var existing = GetById(client.Id);  
            if(existing != null)
            {
                existing.Name = client.Name;    
                existing.Type = client.Type;    
                existing.Document = client.Document;
                existing.Phone = client.Phone;  
            }
        }

        public static void Remove(int id)
        {
            var Client = GetById(id);
            if (Client != null)
            {
                Client.IsDeleted = true;
            }

        }
    }
}