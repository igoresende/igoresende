using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Imposto //alterado p/ abstract para Design Patternn Decorator , Interface para Strategy
    {
        /*
         * Sempre que temos comportamentos que podem ser compostos por comportamentos de outras classes 
         * envolvidas em uma mesma hierarquia, como os impostos, que podem ser composto por outros impostos. 
         * O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, 
         * quais instancias serão utilizadas para realizar o trabalho.
         */
        public Imposto OutroImposto { get; set; } 
        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) 
                return 0;
            return OutroImposto.Calcula(orcamento);
        }
        
    }
}
