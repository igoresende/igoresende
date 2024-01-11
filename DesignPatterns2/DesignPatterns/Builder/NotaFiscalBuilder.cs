using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Domain
{
    public class NotaFiscalBuilder
    {
        /*
         * Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação 
         * complicada, podemos esconder tudo isso em um Builder. Além de centralizar o código de criação e facilitar a manutenção, 
         * ainda facilitamos a vida das classes que precisam criar essa classe complexa.
         */
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public String Observacoes { get; private set; }

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this; // retorno eu mesmo, o próprio builder, para que o cliente continue utilizando
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            this.TodosItens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.Data = novaData;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal,
                                Impostos, TodosItens, Observacoes);
        }
    }
}
