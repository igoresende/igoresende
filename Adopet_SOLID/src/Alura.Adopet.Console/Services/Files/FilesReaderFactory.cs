using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Services.Files;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;
public static class FilesReaderFactory
{
    public static IFilesReader<Pet>? CreatePetFrom(string filePath)
    {
        var extension = Path.GetExtension(filePath);
        switch (extension)
        {
            case ".csv":
                return new PetCSV(filePath);
            case ".json":
                return new FilesReaderJson<Pet>(filePath);
            default: return null;
        }
    }

    public static IFilesReader<Client>? CreateClientFrom(string filePath)
    {
        var extension = Path.GetExtension(filePath);
        switch (extension)
        {
            case ".csv":
                return new ClientCSV(filePath);
            case ".json":
                return new FilesReaderJson<Client>(filePath);
            default: return null;
        }
    }
}
