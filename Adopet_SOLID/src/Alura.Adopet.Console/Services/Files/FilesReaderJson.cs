using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos;
public class FilesReaderJson<T>: IFilesReader<T>
{
    private string filePath;
    public FilesReaderJson(string filePath)
    {
        this.filePath = filePath;
    }

    public IEnumerable<T> DoRead()
    {
        using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<IEnumerable<T>>(stream)??Enumerable.Empty<T>();
    }
}
