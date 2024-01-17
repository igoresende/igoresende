using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos;

public abstract class FilesReaderCsv<T> : IFilesReader<T>
{
    private string caminhoDoArquivoASerLido;
    public FilesReaderCsv(string caminhoDoArquivoASerLido)
    {
        this.caminhoDoArquivoASerLido = caminhoDoArquivoASerLido;
    }

    public virtual IEnumerable<T> DoRead()
    {
        if (string.IsNullOrEmpty(caminhoDoArquivoASerLido))
        {
            return null;
        }
        List<T> lista = new List<T>();
        using StreamReader sr = new StreamReader(caminhoDoArquivoASerLido);
        while (!sr.EndOfStream)
        {
            string? line = sr.ReadLine();
            if (line is not null)
            {
                var obj = CreateFromLineCSV(line);
                lista.Add(obj);
            }
        }
        return lista;
    }

    public abstract T CreateFromLineCSV(string line);
}
