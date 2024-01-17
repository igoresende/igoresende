using Alura.Adopet.Console.Servicos.Abstracoes;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes.Builder
{
    internal class ApiServiceMockBuilder
    {
        public static Mock<IApiService<T>> GetMock<T>()
        {
            return new Mock<IApiService<T>>(MockBehavior.Default);
        }

        public static Mock<IApiService<T>> GetMockList<T>(List<T> lista)
        {
            var mockService = new Mock<IApiService<T>>(MockBehavior.Default);
            mockService.Setup(_ => _.ListAsync())
                .ReturnsAsync(lista);
            return mockService;
        }
    }
}
