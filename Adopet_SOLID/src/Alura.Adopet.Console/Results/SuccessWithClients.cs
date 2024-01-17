using Alura.Adopet.Console.Modelos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Results
{
    public class SuccessWithClients : Success
    {
        public SuccessWithClients(IEnumerable<Client> data, string mensagem) : base(mensagem)
        {
            Data = data;
        }

        public IEnumerable<Client> Data { get; }
    }
}
