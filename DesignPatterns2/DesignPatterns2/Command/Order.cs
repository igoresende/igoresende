using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Command
{
    public class Order
    {
        public String Client { get; private set; }
        public double Value { get; private set; }
        public Status Status { get; private set; }
        public DateTime EndDate { get; private set; }

        public Order(String client, double value)
        {
            this.Client = client;
            this.Value = value;
            this.Status = Status.New;
        }

        public void Pay()
        {
            Status = Status.Paid;
        }

        public void Finish()
        {
            EndDate = DateTime.Now;
            Status = Status.Delivered;
        }
    }
}
