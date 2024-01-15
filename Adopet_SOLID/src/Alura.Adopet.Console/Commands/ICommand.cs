using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    public interface ICommand
    {
        Task<Result> ExecutarAsync();
    }
}
