using DesignPatterns2.Adapter;

namespace DesignPatterns2.Facade
{
    public class Invoice
    {
        public Invoice(Client client, double value)
        {
            Client = client;
            Value = value;
        }

        public Client Client { get; }
        public double Value { get; }
    }
}