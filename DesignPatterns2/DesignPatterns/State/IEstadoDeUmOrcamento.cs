using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IEstadoDeUmOrcamento
    {
        /*
         * Design Pattern State é a necessidade de implementação de uma máquina de estados. Geralmente, o controle das possíveis
         * transições são vários e complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o 
         * controle dos estados simples e organizados através da criação de classes que representem cada estado 
         * e saiba controlar as transições.
         */
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
