using System;

namespace DesignPatterns.Domain
{
    public class ItemDaNota
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(String descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}