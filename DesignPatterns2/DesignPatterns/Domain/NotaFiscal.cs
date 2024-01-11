using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Domain
{
    public class NotaFiscal
    {
        private String RazaoSocial { get;  set; }
        private String Cnpj { get;  set; }
        private DateTime DataDeEmissao { get;  set; }
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public String Observacoes { get; private set; }

        public NotaFiscal(String razaoSocial, String cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<ItemDaNota> itens,
                      String observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
