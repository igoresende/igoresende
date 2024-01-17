using System.ComponentModel.DataAnnotations;

namespace Alura.Adopet.API.Dominio
{
    public class Client
    {
        public Client()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
    }
}
