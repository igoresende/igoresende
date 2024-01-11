using DesignPatterns.Interfaces;
using DesignPatterns.State;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Orcamento
    {
        public Orcamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }
        public double Valor { get; set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }
        public List<Item> Itens {  get; private set; }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}