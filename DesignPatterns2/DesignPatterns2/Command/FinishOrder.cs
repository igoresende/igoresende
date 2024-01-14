using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Command
{
    public class FinishOrder : ICommand
    {
        private Order order;

        public FinishOrder(Order order)
        {
            this.order = order;
        }
        public void Execute()
        {
            order.Finish();
        }
    }
}
