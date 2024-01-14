using DesignPatterns2.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Facade
{
    public class CompanyFacade
    {
        /*
         * Uma façade serve como uma frente única para os serviços disponibilizados por um ou mais sub-sistemas, 
         * provendo uma maneira mais simples para consumo do mesmo
         */
        public Client SearchClient(string cpf)
        {
            return new ClientDao().SearchByCpf(cpf);
        }

        public Invoice CreateInvoice(Client client, double valor)
        {
            Invoice invoice = new Invoice(client, valor);
            return invoice;
        }

        public Charge GenerateCharge(Invoice invoice)
        {
            Charge charge = new Charge(Tipo.Boleto, invoice);
            charge.Send();
            return charge;
        }

        public ClientContact MakeContact(Client cliente, Invoice invoice)
        {
            ClientContact contact = new ClientContact(cliente, invoice);
            contact.Trigger();
            return contact;
        }
    }
}
