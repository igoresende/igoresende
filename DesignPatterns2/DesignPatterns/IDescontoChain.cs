using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IDescontoChain
    {
        /*
         * O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo 
         * com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior 
         * não satisfaça a condição.
         */
        double Desconta(Orcamento orcamento);
        IDescontoChain Proximo{ get;set;}
    }
}
