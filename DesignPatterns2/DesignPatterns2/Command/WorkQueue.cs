using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DesignPatterns2.Command
{
    public class WorkQueue
    {
        private IList<ICommand> commands = new List<ICommand>();

        public void Adiciona(ICommand command)
        {
            commands.Add(command);
        }

        public void Processa()
        {
            foreach (ICommand comando in commands)
            {
                comando.Execute();
            }
        }
    }
}
