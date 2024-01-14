using DesignPatterns2.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Singleton
{
    public class CompanyFacadeSingleton
    {
        //O Singleton nos ajuda a ter uma única instância do objeto ao longo do sistema.
        /* O Singleton possibilita que o usuário crie uma instância global para determinado objeto. 
         * Isso pode ser interessante, mas tem problemas similares ao de variáveis globais no mundo procedural, 
         * afinal o objeto é único e disponível para todos.Se não usar com parcimônia, o seu código sofrerá problemas de manutenção.
         */
        private static CompanyFacade instance = new CompanyFacade();

        public CompanyFacade Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
