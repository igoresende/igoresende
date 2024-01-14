using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public interface IExpression
    {
        /*
         * O padrão Interpreter é geralmente útil para interpretar DSLs. É comum que, ao ler a string (como por exemplo 2+3/4), 
         * o programa transforme-a em uma estrutura de dados melhor (como as nossas classes Expression) e aí interprete essa árvore.
         */
        int Avail();
        void Accept(IVisitor visitor);
    }
}
