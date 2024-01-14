using DesignPatterns2.Adapter;
using DesignPatterns2.Bridge;
using DesignPatterns2.Command;
using DesignPatterns2.Facade;
using DesignPatterns2.Factory;
using DesignPatterns2.Flyweight;
using DesignPatterns2.Interpreter;
using DesignPatterns2.Memento;
using DesignPatterns2.Singleton;
using DesignPatterns2.Visitor;
using System;
using System.Collections.Generic;
using System.Data;

namespace DesignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestConnectionFactory();
            //TestNotasMusicaisFlyweight();
            TestHistoricoMemento();
            TestExpressionInterpreter();
            //TestSendMessageDpBridge();
            //TestOrderCommand();
            //TestXmlAdapter();
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

        public static void TestExpressionInterpreter()
        {
            IExpression esquerda = new Subtraction(new Number(10), new Number(5));
            IExpression direita = new Sum(new Number(2), new Number(10));

            IExpression conta = new Sum(esquerda, direita);

            int resultado = conta.Avail();

            TestDpVisitor(conta);

            Console.WriteLine(resultado);

            
            //Expression sum = Expression.Add(Expression.Constant(10), Expression.Constant(20));
            //Func<int> interpreter = Expression.Lambda<Func<int>>(sum).Compile();
            //int result = interpreter();
        }

        public static void TestDpVisitor(IExpression conta) 
        {
            PrinterVisitor printer= new PrinterVisitor();
            conta.Accept(printer);
        }

        public static void TestSendMessageDpBridge()
        {
            ISender sender = new SendByEmail();
            IMessage message = new AdministrativeMessage("Igor");
            message.Sender = sender;

            message.Send();

            ISender senderSecond = new SendBySms();
            IMessage messageSecond = new UserMessage("Carvalho");
            messageSecond.Sender = senderSecond;

            messageSecond.Send();
        }
        public static void TestOrderCommand() 
        {
            Order order1 = new Order("Igor", 150.0);
            Order order2 = new Order("Resende", 250.0);
            
            WorkQueue fila = new WorkQueue();

            fila.Adiciona(new PayOrder(order1));
            fila.Adiciona(new PayOrder(order2));
            fila.Adiciona(new FinishOrder(order1));

            fila.Processa();
        }
        public static void TestXmlAdapter() 
        {
            Client client = new Client();
            client.Name = "Igor";
            client.Address = "48, Cmt Miranda St";
            client.BirthDate= DateTime.Now;

            String xml = new XmlGeneratorAdapter().GenerateXml(client);
            Console.WriteLine(xml);
        }
        public static void TestFacadeSingleton() 
        {
            string cpf = "12345";
            CompanyFacade facade = new CompanyFacadeSingleton().Instance;
            Client client = facade.SearchClient(cpf);

            var bill = facade.CreateInvoice(client, 3000);
            facade.GenerateCharge(bill);
        }
    }
}
