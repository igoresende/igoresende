namespace Alura.Adopet.Console.Atributos;

[AttributeUsage(AttributeTargets.Class)]
public sealed class DocComandoAttribute : Attribute
{
    public DocComandoAttribute(string instruction, string document)
    {
        Instruction = instruction;
        Document = document;
    }

    public string Instruction { get; }
    public string Document { get; }
}
