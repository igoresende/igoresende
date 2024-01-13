using DesignPatterns2.Factory;
using DesignPatterns2.Flyweight;
using DesignPatterns2.Memento;
using System;
using System.Collections.Generic;
using System.Data;

namespace DesignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestNotasMusicaisFlyweight();
            TestHistoricoMemento();
            Console.WriteLine("Studying Design Patterns!");
        }

        public static void TestConnectionFactory()
        {
            IDbConnection connection = new ConnectionFactory().GetConnection();
        }
        public static void TestNotasMusicaisFlyweight()
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>(){
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("sol"),
                notas.Pega("la"),
                notas.Pega("si"),
            };
            Piano piano = new Piano();
            piano.Toca(musica);
        }
        public static void TestHistoricoMemento()
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
        }
    }
}
