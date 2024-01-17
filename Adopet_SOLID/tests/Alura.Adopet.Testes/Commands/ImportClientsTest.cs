using Alura.Adopet.Console.Commands;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Testes.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes.Commands
{
    public class ImportClientsTest
    {
        [Fact]
        public async Task WhenClientIsInFileMustBeImported()
        {
            //arrange
            List<Client> clientList = new();
            var client = new Client(id : Guid.NewGuid(), nome: "Igor Resende", email: "igorteste@gmail.com");
            clientList.Add(client);

            var fileReader = LeitorDeArquivosMockBuilder.GetMock(clientList);
            var mockService= ApiServiceMockBuilder.GetMock<Client>();
            var import = new ImportClients(mockService.Object, fileReader.Object);

            //act
            var result = await import.ExecutarAsync();
            //assert
            Assert.True(result.IsSuccess);
            var success = (SuccessWithClients)result.Successes[0];
            Assert.Equal("Igor Resende",success.Data.First().Name);
        }
    }
}
