using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Services.Http
{
    public class ClientService : IApiService<Client>
    {
        public HttpClient client;
        public ClientService(HttpClient client)
        {
            this.client = client;
        }
        public Task CreateAsync(Client objClient)
        {
            return client.PostAsJsonAsync("client/add", objClient);
        }

        public async Task<IEnumerable<Client>?> ListAsync()
        {
            HttpResponseMessage response = await client.GetAsync("client/list");
            return await response.Content.ReadFromJsonAsync<IEnumerable<Client>>();
        }
    }
}
