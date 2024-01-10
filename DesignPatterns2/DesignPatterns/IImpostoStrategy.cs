using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IImpostoStrategy
    {
        /*
         * O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar 
         * entre eles em diferentes pedaços da aplicação. 
         * Se é nítido que novas estratégias aparecerão, com certeza um Strategy é mais limpo do que um conjunto de ifs.
         */
        double Calcula(Orcamento orcamento);
    }
}
