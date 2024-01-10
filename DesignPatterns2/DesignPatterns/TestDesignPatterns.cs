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
            //TestaDescontos();
        }

        public static void TesteDeImpostos() //Testing Strategy - Design Pattern
        {
            /*
            * O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar 
            * entre eles em diferentes pedaços da aplicação. 
            * Se é nítido que novas estratégias aparecerão, com certeza um Strategy é mais limpo do que um conjunto de ifs.
            */
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500.0);
            CalculaImpostos calculador = new CalculaImpostos();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

        }

        public static void TestaDescontos() // Testing Chain Of Responsability
        {

            IDescontoChain d1 = new DescontoPorCincoItens();
            IDescontoChain d2 = new DescontoPorMaisDeQuinhentosReais();
            IDescontoChain d3 = new DescontoPorVendaCasada();
            IDescontoChain d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;
            Orcamento orcamento = new Orcamento(500.0);

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);

        }
    }
}
