using DesignPatterns.Domain;
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
            //TestaImpostoDecorator();
            //TestesDoDescontoExtraState();

        }

        public static void TesteDeImpostos() //Testing Strategy - Design Pattern
        {
            /*
            * O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar 
            * entre eles em diferentes pedaços da aplicação. 
            * Se é nítido que novas estratégias aparecerão, com certeza um Strategy é mais limpo do que um conjunto de ifs.
            */
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
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

        public static void TestaImpostoDecorator()
        {
            Imposto iss = new ISS(new ICMS());
            Orcamento orcamento = new Orcamento(500);
            double valor = iss.Calcula(orcamento);
            Console.WriteLine(valor);
        }

        public static void TestesDoDescontoExtraState() //DesignPattern State
        {
            Orcamento reforma = new Orcamento(500.0);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
            reforma.Aprova(); // aprova nota!

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

            reforma.Finaliza();

            // reforma.AplicaDescontoExtra(); lancaria excecao, pois não pode dar desconto nesse estado
            // reforma.Aprova(); lança exceção, pois não pode ir para aprovado

        }
        public static void TestaBuilder()
        {

            NotaFiscalBuilder nfBuilder = new NotaFiscalBuilder().ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .Com(new ItemDaNota("item 1", 100.0))
                              .Com(new ItemDaNota("item 2", 200.0))
                              .Com(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar nf pessoalmente")
                              .NaDataAtual();

            NotaFiscal notaFiscal = nfBuilder.Constroi();
          
        }
    }
}
