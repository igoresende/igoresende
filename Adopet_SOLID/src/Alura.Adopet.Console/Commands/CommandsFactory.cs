using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Console.Comandos;

public static class CommandsFactory
{
    public static ICommand? CriarComando(string[] arguments)
    {
        if ((arguments is null) || (arguments.Length == 0))
        {
            return null;
        }
        var command = arguments[0];
        switch (command)
        {
            case "import":
                var httpClientPet = new HttpClientPet(new AdopetAPIClientFactory().CreateClient("adopet"));
                var filesReader = FilesReaderFactory.CreatePetFrom(arguments[1]);
                if (filesReader is null) { return null; }
                return new Import(httpClientPet, filesReader);

            case "list":
                var httpClientPetList = new HttpClientPet(new AdopetAPIClientFactory().CreateClient("adopet"));
                return new List(httpClientPetList);

            case "show":
                var filesReaderShow = FilesReaderFactory.CreatePetFrom(arguments[1]);
                if (filesReaderShow is null) { return null; }
                return new Show(filesReaderShow);

            case "help":
                var commandToShow = arguments.Length==2? arguments[1] : null;
                return new Help(commandToShow);

            default: return null;
        }           
    }
}
