using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Flyweight
{
    internal class Piano
    {
        public void Toca(IList<INota> musica) 
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}
