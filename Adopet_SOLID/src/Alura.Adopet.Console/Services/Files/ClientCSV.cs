using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Services.Files
{
    public class ClientCSV : FilesReaderCsv<Client>
    {
        public ClientCSV(string caminhoDoArquivoASerLido) : base(caminhoDoArquivoASerLido)
        {
        }

        public override Client CreateFromLineCSV(string line)
        {
            string[] propriedades = line.Split(';');
            

            return new Client(id: Guid.Parse(propriedades[0]), nome: propriedades[1], email: propriedades[2]); 
        }
    }
}
