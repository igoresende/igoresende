using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public class Subtraction : IExpression
    {
        public IExpression Left;
        public IExpression Right;

        public Subtraction(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
            new Subtraction(Left, Right);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSubtraction(this);
        }

        public int Avail()
        {
            int resulLeft = Left.Avail();
            int resultRight = Right.Avail();
            return resulLeft - resultRight;
        }
    }
}
