using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System.Text.Json;

namespace Alura.Adopet.Console.Servicos.Arquivos;
public class FilesReaderJson: IFilesReader
{
    private string filePath;
    public FilesReaderJson(string filePath)
    {
        this.filePath = filePath;
    }

    public IEnumerable<Pet> DoRead()
    {
        using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<IEnumerable<Pet>>(stream)??Enumerable.Empty<Pet>();
    }
}
