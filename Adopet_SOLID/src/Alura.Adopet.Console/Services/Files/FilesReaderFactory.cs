using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;
public static class FilesReaderFactory
{
    public static IFilesReader? CreatePetFrom(string filePath)
    {
        var extension = Path.GetExtension(filePath);
        switch (extension)
        {
            case ".csv":
                return new FilesReaderCsv(filePath);
            case ".json":
                return new FilesReaderJson(filePath);
            default: return null;
        }
    }
}
