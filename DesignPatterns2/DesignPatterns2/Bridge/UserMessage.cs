using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Bridge
{
    public class UserMessage : IMessage
    {
        /*
         * Quando temos uma hierarquia de classes que é responsável por diversas características do sistema (formatação e 
         * envio da mensagem, no exemplo), podemos utilizar o padrão bridge para separar as características em diversas hierarquias 
         * ligando-as através da composição de classes.
         */
        public ISender Sender { get; set ; }
        string Name;
        public UserMessage(string name)
        {
            Name = name;
        }
        public string Format()
        {
            return String.Format("Message for the user {0}", Name);
        }

        public void Send()
        {
            this.Sender.Send(this);
        }
    }
}
