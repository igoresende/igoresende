using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class TestDesignPatterns
    {
        static void Main(string[] args)
        {
            //TesteDeImpostos();
        }

        public static void TesteDeImpostos() //Testing Strategy - Design Pattern
        {
            
                IImpostoStrategy iss = new ISS();
                IImpostoStrategy icms = new ICMS();
                Orcamento orcamento = new Orcamento(500.0);
                CalculaImpostos calculador = new CalculaImpostos();

                // Calculando o ISS
                calculador.RealizaCalculo(orcamento, iss);

                // Calculando o ICMS        
                calculador.RealizaCalculo(orcamento, icms);
            
        }
    }
}
