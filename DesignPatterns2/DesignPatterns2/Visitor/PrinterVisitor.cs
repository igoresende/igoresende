using DesignPatterns2.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Number = DesignPatterns2.Interpreter.Number;

namespace DesignPatterns2.Visitor
{
    public class PrinterVisitor : IVisitor
    {
        public void VisitNumber(Number number)
        {
            Console.WriteLine(number.Value);
        }

        public void VisitSubtraction(Subtraction subtraction)
        {
            Console.Write("(");
            subtraction.Left.Accept(this);
            Console.Write(" - ");
            subtraction.Right.Accept(this);
            Console.Write(")");
        }

        public void VisitSum(Sum sum)
        {
            Console.Write("(");
            sum.Left.Accept(this);
            Console.Write(" + ");
            sum.Right.Accept(this);
            Console.Write(")");
        }
    }
}
