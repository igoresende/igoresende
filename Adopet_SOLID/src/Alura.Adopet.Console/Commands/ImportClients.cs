using Alura.Adopet.Console.Atributos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Console.Servicos.Abstracoes;
using FluentResults;
using ICommand = Alura.Adopet.Console.Comandos.ICommand;

namespace Alura.Adopet.Console.Commands
{
    [DocComandoAttribute(instrucao: "import-clients",
        documentacao: "adopet import-clients <ARQUIVO> comando que realiza a importação do arquivo de clients.")]
    public class ImportClients : ICommand
    {
        private IApiService<Client> apiService;
        private IFilesReader<Client> leitorDeArquivo;

        public ImportClients(IApiService<Client> apiService, IFilesReader<Client> leitor)
        {
            this.apiService = apiService;
            this.leitorDeArquivo = leitor;
        }

        public async Task<Result> ExecutarAsync()
        {
            try
            {
                var lista = leitorDeArquivo.DoRead();
                foreach (var cliente in lista)
                {
                    await apiService.CreateAsync(cliente);
                }
                return Result.Ok().WithSuccess(new SuccessWithClients(lista, "Importação Realizada com Sucesso!"));
            }
            catch (Exception exception)
            {
                return Result.Fail(new Error("Importação falhou!").CausedBy(exception));
            }
        }
    }
}
