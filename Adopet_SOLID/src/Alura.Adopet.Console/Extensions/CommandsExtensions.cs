using Alura.Adopet.Console.Atributos;
using System.Reflection;
using ICommand = Alura.Adopet.Console.Comandos.ICommand;

namespace Alura.Adopet.Console.Extensions
{
    public static class CommandsExtensions
    {
        public static Type? GetTypeCommand(this Assembly assembly, string command)
        {
            return assembly.GetTypes()
                    .Where(t=>!t.IsInterface && t.IsAssignableTo(typeof(ICommand)))
                    .Where(c=>c.GetCustomAttributes<DocComandoAttribute>()
                    .Any(d=>d.Instruction.Equals(command)))
                    .FirstOrDefault();
        }
    }
}
