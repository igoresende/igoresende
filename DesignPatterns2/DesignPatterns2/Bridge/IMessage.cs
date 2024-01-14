using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Bridge
{
    public interface IMessage
    {
        ISender Sender { get; set; }

        void Send();
        string Format();
    }
}
