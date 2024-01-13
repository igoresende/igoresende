using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Memento
{
    internal class Contrato
    {
        public DateTime Data {  get; set; }
        public string Cliente { get; set; }
        public TipoContrato Tipo { get; set; }
        public Contrato(DateTime data, string cliente, TipoContrato contrato) 
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = contrato;
        }
        public void Avanca()
        {
            if(this.Tipo == TipoContrato.Novo)
                this.Tipo = TipoContrato.EmAndamento;
            else if (this.Tipo == TipoContrato.EmAndamento) 
                this.Tipo = TipoContrato.Acertado;
            else if (this.Tipo == TipoContrato.Acertado) 
                this.Tipo = TipoContrato.Concluido;
        }
        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }
        public void Restaura(Estado estado)
        {
            this.Data = estado.Contrato.Data;
            this.Cliente = estado.Contrato.Cliente;
            this.Tipo = estado.Contrato.Tipo;
        }
    }
}
