using Livraria.Enums;

namespace Livraria.Models;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public Estado Estado { get; set; }
}