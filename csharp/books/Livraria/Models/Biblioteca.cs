using Livraria.Enums;

namespace Livraria.Models;

public class Biblioteca
{
    private readonly Dictionary<Livro, string> _emprestimoLista = new Dictionary<Livro, string>();

    public List<Livro> Livros { get; private set; } = new List<Livro>()
    {
        new Livro()
        {
            Autor = "Larissa Manoela",
            Titulo = "Carrosel",
            Estado = Estado.Disponivel
        },
        new Livro()
        {
            Autor = "Luís de Camões",
            Titulo = "Os lusíadas",
            Estado = Estado.Disponivel
        },
        new Livro()
        {
            Autor = "Lucas Neto",
            Titulo = "Os aventureiros",
            Estado = Estado.Disponivel
        },
    };

    public List<Leitor> Leitores { get; private set; } = new List<Leitor>()
    {
        new Leitor()
        {
            Nome = "Jader",
            Sobrenome = " Barbosa Cardoso"
        },
        new Leitor()
        {
            Nome = "Sarah",
            Sobrenome = "Carla Souza"
        },
        new Leitor()
        {
            Nome = "Fernanda",
            Sobrenome = "de Mattos Soares"
        }
    };

    public void Emprestimo(string tituloLivro, string nomeLeitor)
    {
        var livro = Livros.Find(l => l.Titulo == tituloLivro);
        if (livro is null)
        {
            Console.WriteLine($"O livro {tituloLivro} não existe na biblioteca.");
            return;
        }

        var leitor = Leitores.Find(l => l.Nome == nomeLeitor);
        if (leitor is null)
        {
            Console.WriteLine($"O leitor {nomeLeitor} não está cadastrado no sistema.");
            return;
        }

        bool estaSendoUsado = ExisteEmprestimo(livro);
        if (estaSendoUsado)
        {
            Console.WriteLine($"O livro {livro.Titulo} não está disponível para empréstimo.");
            return;
        }

        livro.Estado = Estado.Emprestado;
        _emprestimoLista.Add(livro, leitor.Nome);

        Console.WriteLine($"O livro {livro.Titulo} foi emprestado para o usuário {leitor.Nome} com sucesso!");

        return;
    }

    public void Devolucao(string tituloLivro, string nomeLeitor)
    {
        var livro = Livros.Find(l => l.Titulo == tituloLivro);
        if (livro is null)
        {
            Console.WriteLine($"O livro {tituloLivro} não existe na biblioteca.");
            return;
        }

        var leitor = Leitores.Find(l => l.Nome == nomeLeitor);
        if (leitor is null)
        {
            Console.WriteLine($"O leitor {nomeLeitor} não está cadastrado no sistema.");
            return;
        }

        bool estaSendoUsado = ExisteEmprestimo(livro);
        if (!estaSendoUsado)
        {
            Console.WriteLine($"O livro {livro.Titulo} está disponível, pois não consta empréstimo.");
            return;
        }

        livro.Estado = Estado.Disponivel;
        _emprestimoLista.Remove(livro);

        Console.WriteLine($"O livro {livro.Titulo} foi devolvido com sucesso!");
    }

    public void ListarLivrosDisponiveis()
    {
        var result = Livros
            .Where(livro => livro.Estado == Estado.Disponivel)
            .Select(livro => string.Format("Livro {0}", livro.Titulo));

        var message = string.Join(";\r\n", result);

        Console.WriteLine(message);
    }

    public void ListarLivrosEmprestados()
    {
        var result = _emprestimoLista.Select((kv) => string.Format("Livro {0}", kv.Key.Titulo));

        var message = string.Join("; \n", result);

        Console.WriteLine(message);
    }

    public bool ExisteEmprestimo(Livro livro) => _emprestimoLista.ContainsKey(livro);
}
