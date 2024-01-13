using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Flyweight
{
    internal class NotasMusicais
    {
        /*
         * Um Flyweight serve para quando temos muitas instâncias do mesmo objeto andando pelo sistema, e precisamos economizar. 
         * Para tal, o Flyweight faz uso de uma fábrica modificada, que guarda essas instâncias.
         */
        private static IDictionary<string, INota> notas =
            new Dictionary<string, INota>() {
                {"do", new Do() },
                {"re", new Re() },
                {"mi", new Mi() },
                {"fa", new Fa() },
                {"sol", new Sol() },
                {"la", new La() },
                {"si", new Si() } 
            };
        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}
