using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public class Division : IExpression
    {
        private IExpression Left;
        private IExpression Right;

        public Division(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int Avail()
        {
            int resultadoDaEsquerda = Left.Avail();
            int resultadoDaDireita = Right.Avail();
            return resultadoDaEsquerda / resultadoDaDireita;
        }
    }
}
