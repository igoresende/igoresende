using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Atributos;
using Alura.Adopet.Console.Results;
using FluentResults;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Comandos
{
    [DocComandoAttribute(instruction: "show",
       document: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show:ICommand
    {
        private readonly IFilesReader<Pet> leitor;

        public Show(IFilesReader<Pet> leitor)
        {
            this.leitor = leitor;
        }

        public Task<Result> ExecutarAsync()
        {
            try
            {
               return this.ExibeConteudoArquivo(); 
            }
            catch (Exception exception)
            {
               return Task.FromResult(Result.Fail(new Error("Exibição do arquivo falhou!").CausedBy(exception)));
            }
        }

        private Task<Result> ExibeConteudoArquivo()
        {           
            var listaDepets = leitor.DoRead();       
            return Task.FromResult(Result.Ok().WithSuccess(new SuccessWithPets(listaDepets, "Exibição do arquivo realizada com sucesso!")));

        }
    }
}
