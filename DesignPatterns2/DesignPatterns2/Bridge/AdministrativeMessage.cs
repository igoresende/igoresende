using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Bridge
{
    public class AdministrativeMessage : IMessage
    {
        public ISender Sender { get ; set ; }
        string Name;
        public AdministrativeMessage(string name)
        {
            Name = name;
        }

        public string Format()
        {
            return String.Format("Administrative message for {0}", Name);
        }

        public void Send()
        {
            this.Sender.Send(this);
        }
    }
}
