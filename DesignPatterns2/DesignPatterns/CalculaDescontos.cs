using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculaDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDescontoChain d1 = new DescontoPorCincoItens();
            IDescontoChain d2 = new DescontoPorMaisDeQuinhentosReais();

            d1.Proximo = d2;

            return d1.Desconta(orcamento);
        }
    }
}
