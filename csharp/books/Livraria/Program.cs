using Livraria.Models;

var biblioteca = new Biblioteca();

Console.WriteLine("---------Disponíveis----------");
biblioteca.ListarLivrosDisponiveis();
Console.WriteLine("---------------------------");

Console.WriteLine();


Console.WriteLine("--------Emprestados---------");
biblioteca.ListarLivrosEmprestados();
Console.WriteLine("---------------------------");


Console.WriteLine();

Console.WriteLine("--------Efetuando Empréstimo---------");
biblioteca.Emprestimo("Carrosel", "Jader");
Console.WriteLine("---------------------------");

Console.WriteLine();

Console.WriteLine("---------Disponíveis----------");
biblioteca.ListarLivrosDisponiveis();
Console.WriteLine("---------------------------");

Console.WriteLine();

Console.WriteLine("--------Emprestados---------");
biblioteca.ListarLivrosEmprestados();
Console.WriteLine("---------------------------");

Console.WriteLine("--------Efetuando Devolução---------");
biblioteca.Devolucao("Carrosel", "Jader");
Console.WriteLine("---------------------------");


Console.WriteLine("---------Disponíveis----------");
biblioteca.ListarLivrosDisponiveis();
Console.WriteLine("---------------------------");

Console.WriteLine();

Console.WriteLine("--------Emprestados---------");
biblioteca.ListarLivrosEmprestados();
Console.WriteLine("---------------------------");