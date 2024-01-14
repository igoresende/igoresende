using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Command
{
    public interface ICommand
    {
        /*
         * A ideia do Command é abstrair um comando que deve ser executado, pois não é possível executá-lo naquele momento 
         * (pois precisamos por em uma fila ou coisa do tipo).Já no Strategy, a ideia é que você tenha uma estratégia 
         * (um algoritmo) para resolver um problema.
         */
        void Execute();
    }
}
