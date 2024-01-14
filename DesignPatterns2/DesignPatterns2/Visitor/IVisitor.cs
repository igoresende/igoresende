using DesignPatterns2.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Visitor
{
    public interface IVisitor
    {
        /*
         * A finalidade do visitor dentro do código é simplesmente percorrer toda a árvore de expressão para executar alguma lógica.
         * É utilizado para imprimir as expressões, mas ele também poderia ser utilizado para realizar cálculos com a expressão 
         * ou qualquer outra tarefa que dependa do processamento dos nós de nossa árvore de expressão.
         */
        void VisitSum(Sum sum);
        void VisitSubtraction(Subtraction subtraction);
        void VisitNumber(Number number);
    }
}
