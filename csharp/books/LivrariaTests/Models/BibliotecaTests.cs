using Livraria.Enums;
using Livraria.Models;
using System.Numerics;

namespace LivrariaTests.Models;

[TestClass]
public class BibliotecaTests
{
    [TestMethod]
    public void TestEmprestimo_Sucesso()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var biblioteca = new Biblioteca();
        var leitor = "Jader";
        var livro = "Carrosel";

        //Act
        biblioteca.Emprestimo(livro, leitor);

        //Assert
        var result = sw.ToString().Trim();
        Assert.AreEqual(result, $"O livro {livro} foi emprestado para o usuário {leitor} com sucesso!");
        Assert.AreEqual(Estado.Emprestado, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestEmprestimo_LivroNaoExiste()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var livroInexistente = "LivroNaoExistente";
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.Emprestimo(livroInexistente, "Jader");

        //Assert
        var result = sw.ToString().Trim();
        Assert.AreEqual(result, $"O livro {livroInexistente} não existe na biblioteca.");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestEmprestimo_LeitorNaoExiste()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var leitorInexistente = "LeitorNaoExistente";
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.Emprestimo("Carrosel", leitorInexistente);

        //Assert
        var result = sw.ToString().Trim();
        Assert.AreEqual(result, $"O leitor {leitorInexistente} não está cadastrado no sistema.");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestEmprestimo_JaEstaEmprestado()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var biblioteca = new Biblioteca();
        var nomeLivro = "Carrosel";

        //Act
        biblioteca.Emprestimo(nomeLivro, "Jader");
        biblioteca.Emprestimo(nomeLivro, "Sarah");

        //Assert
        var result = sw.ToString().Trim().Split("\r\n");
        Assert.AreEqual(result[1], $"O livro {nomeLivro} não está disponível para empréstimo.");
        Assert.AreEqual(Estado.Emprestado, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestDevolucao_Sucesso()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var biblioteca = new Biblioteca();
        var livro = "Carrosel";

        //Act
        biblioteca.Emprestimo(livro, "Jader");
        biblioteca.Devolucao(livro, "Jader");


        //Assert
        var result = sw.ToString().Trim().Split("\r\n");
        Assert.AreEqual(result[1], $"O livro {livro} foi devolvido com sucesso!");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestDevolucao_LivroNaoExiste()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var livroInexistente = "LivroNaoExistente";
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.Devolucao(livroInexistente, "Jader");

        //Assert
        var result = sw.ToString().Trim();
        Assert.AreEqual(result, $"O livro {livroInexistente} não existe na biblioteca.");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestDevolucao_LeitorNaoExiste()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var nomeLeitorInexistente = "AlgumLeitorQueNaoExiste";
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.Devolucao("Carrosel", nomeLeitorInexistente);

        //Assert
        var result = sw.ToString().Trim();

        Assert.AreEqual(result, $"O leitor {nomeLeitorInexistente} não está cadastrado no sistema.");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestDevolucao_LivroNaoFoiEmprestado()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var livro = "Carrosel";
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.Devolucao(livro, "Jader");

        //Assert
        var result = sw.ToString().Trim();

        Assert.AreEqual(result, $"O livro {livro} está disponível, pois não consta empréstimo.");
        Assert.AreEqual(Estado.Disponivel, biblioteca.Livros[0].Estado);
    }

    [TestMethod]
    public void TestListarLivrosDisponiveis()
    {
        //Arrange
        var sw = GetAndSetConsoleToStringWriter();
        var biblioteca = new Biblioteca();

        //Act
        biblioteca.ListarLivrosDisponiveis();

        //Assert
        string result = sw.ToString().Trim();
        Assert.IsTrue(result.Contains("Carrosel") && result.Contains("Os lusíadas") && result.Contains("Os aventureiros"));
    }

    [TestMethod]
    public void TestListarLivrosEmprestados()
    {
        //Arramge
        var sw = GetAndSetConsoleToStringWriter();
        var biblioteca = new Biblioteca();
        biblioteca.Emprestimo("Carrosel", "Jader");

        //Act
        biblioteca.ListarLivrosEmprestados();

        //Assert
        string result = sw.ToString().Trim();
        Assert.IsTrue(result.Contains("Carrosel"));
    }

    [TestMethod]
    public void TestExisteEmprestimo_True()
    {
        //Arrange
        var biblioteca = new Biblioteca();
        biblioteca.Emprestimo("Carrosel", "Jader");
        var livro = biblioteca.Livros.First();

        //Act
        var result = biblioteca.ExisteEmprestimo(livro);

        //Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestExisteEmprestimo_False()
    {
        //Arrange
        var biblioteca = new Biblioteca();
        var livro = biblioteca.Livros.First();

        //Act
        var result = biblioteca.ExisteEmprestimo(livro);

        //Assert
        Assert.IsFalse(result);
    }

    private static StringWriter GetAndSetConsoleToStringWriter()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        return stringWriter;
    }
}

