using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Services.Files;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Testes.Servicos;
public class FileReaderFactoryTest
{
    [Fact]
    public void QuantoExtensaoForCsvDeveRetornarTipoLeitorDeArquivoCsv()
    {
        // arrange
        string caminhoArquivo = "pets.csv";

        // act
        var leitor = FilesReaderFactory.CreatePetFrom(caminhoArquivo);

        // assert
        Assert.IsType<PetCSV>(leitor);
    }

    [Fact]
    public void QuantoExtensaoForJsonDeveRetornarTipoLeitorDeArquivoJson()
    {
        // arrange
        string caminhoArquivo = "pets.json";

        // act
        var leitor = FilesReaderFactory.CreatePetFrom(caminhoArquivo);

        // assert
        Assert.IsType<FilesReaderJson<Pet>>(leitor);
    }

    [Fact]
    public void QuantoExtensaoNaoSuportadaDeveRetornarNulo()
    {
        // arrange
        string caminhoArquivo = "pets.xsl";

        // act
        var leitor = FilesReaderFactory.CreatePetFrom(caminhoArquivo);

        // assert
        Assert.Null(leitor);
    }

}
