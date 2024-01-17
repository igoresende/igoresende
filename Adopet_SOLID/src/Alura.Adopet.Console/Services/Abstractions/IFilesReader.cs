namespace Alura.Adopet.Console.Servicos.Abstracoes;
public interface IFilesReader<T>
{
    IEnumerable<T> DoRead();
}
