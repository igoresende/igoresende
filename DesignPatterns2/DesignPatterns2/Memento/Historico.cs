using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Memento
{
    internal class Historico
    {
        /*
         * Um possível problema é a quantidade de memória que ele pode ocupar, afinal estamos guardando muitas instâncias de objetos 
         * que podem ser pesados. Por isso, dependendo do tamanho dos seus objetos, a classe Estado pode passar a guardar não 
         * o objeto todo, mas sim somente as propriedades que mais fazem sentido. Nada impede você também de limitar
         * a quantidade máxima de objetos no histórico que será armazenado.
         */
        private IList<Estado> Estados = new List<Estado>();
        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }
        public Estado Recupera(int indice)
        {
            return Estados[indice];
        }
    }
}
