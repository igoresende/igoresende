using DesignPatterns2.Adapter;
using System;

namespace DesignPatterns2.Facade
{
    public class ClientContact
    {
        public ClientContact(Client cliente, Invoice invoice)
        {
            Cliente = cliente;
            Invoice = invoice;
        }

        public Client Cliente { get; }
        public Invoice Invoice { get; }

        internal void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}