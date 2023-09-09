using Livraria.Models;
using Livraria.Enums;

namespace LivrariaTests.Models;

[TestClass]
public class LivroTests
{
    [TestMethod]
    public void TestProperties()
    {
        // Arrange
        var livro = new Livro
        {
            // Act
            Titulo = "The Great Book",
            Autor = "John Doe",
            Estado = Estado.Emprestado
        };

        // Assert
        Assert.AreEqual("The Great Book", livro.Titulo);
        Assert.AreEqual("John Doe", livro.Autor);
        Assert.AreEqual(Estado.Emprestado, livro.Estado);
    }
}
