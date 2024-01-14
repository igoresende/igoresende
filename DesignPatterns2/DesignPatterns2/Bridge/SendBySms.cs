using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Bridge
{
    public class SendBySms : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message by SMS");
            Console.WriteLine(message.Format());
        }
    }
}
