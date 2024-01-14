using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Bridge
{
    public class SendByEmail : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message by e-mail");
            Console.WriteLine(message.Format());
        }
    }
}
