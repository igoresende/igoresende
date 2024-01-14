using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Interpreter
{
    public class Square : IExpression
    {
        private IExpression Value;
        
        public Square(IExpression value)
        {
            this.Value = value;
        }

        public void Accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int Avail()
        {
            return (int)Math.Sqrt(Value.Avail());
        }
    }
}
