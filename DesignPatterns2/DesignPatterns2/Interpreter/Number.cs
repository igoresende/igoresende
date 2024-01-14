using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public class Number : IExpression
    {
        public int Value;

        public Number(int value) 
        {
            Value = value;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitNumber(this);
        }

        public int Avail()
        {
            return Value;
        }
    }
}
