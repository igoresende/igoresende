using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.TestesIntegracao.Builder;

internal static class LeitorDeArquivosMockBuilder
{
    public static Mock<FilesReaderCsv<Pet>> GetMock(List<Pet> listaDePet)
    {
        var leitorDeArquivo = new Mock<FilesReaderCsv<Pet>>(MockBehavior.Default,
            It.IsAny<string>());

        leitorDeArquivo.Setup(_ => _.DoRead()).Returns(listaDePet);

        return leitorDeArquivo;
    }
}
