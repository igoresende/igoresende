using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.Testes.Builder;

internal static class LeitorDeArquivosMockBuilder
{
    public static Mock<IFilesReader<T>> GetMock<T>(List<T> lista)
    {
        var leitorDeArquivo = new Mock<IFilesReader<T>>(MockBehavior.Default);

        leitorDeArquivo.Setup(_ => _.DoRead()).Returns(lista);

        return leitorDeArquivo;
    }
}
