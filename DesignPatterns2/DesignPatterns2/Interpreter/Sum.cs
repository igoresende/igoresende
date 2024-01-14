using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public class Sum : IExpression
    {
        public IExpression Left;
        public IExpression Right;

        public Sum(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
            new Sum(Left, Right);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSum(this);
        }

        public int Avail()
        {
            int resulLeft = Left.Avail();
            int resultRight = Right.Avail();
            return resulLeft + resultRight;
        }
    }
}
