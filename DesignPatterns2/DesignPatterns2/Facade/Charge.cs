using System;

namespace DesignPatterns2.Facade
{
    public class Charge
    {
        public Charge(object boleto, Invoice invoice)
        {
            Boleto = boleto;
            Invoice = invoice;
        }

        public object Boleto { get; }
        public Invoice Invoice { get; }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}