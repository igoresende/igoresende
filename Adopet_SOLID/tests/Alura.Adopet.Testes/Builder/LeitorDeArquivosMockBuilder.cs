using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.Testes.Builder;

internal static class LeitorDeArquivosMockBuilder
{
    public static Mock<FilesReaderCsv> GetMock(List<Pet> listaDePet)
    {
        var leitorDeArquivo = new Mock<FilesReaderCsv>(MockBehavior.Default,
            It.IsAny<string>());

        leitorDeArquivo.Setup(_ => _.DoRead()).Returns(listaDePet);

        return leitorDeArquivo;
    }
}
