using Livraria.Models;

namespace LivrariaTests.Models;

[TestClass]
public class LeitorTests
{
    [TestMethod]
    public void TestNomeProperty()
    {
        // Arrange
        var leitor = new Leitor
        {
            // Act
            Nome = "Matthew",
            Sobrenome = "Almeida"
        };

        // Assert
        Assert.AreEqual("Matthew", leitor.Nome);
        Assert.AreEqual("Almeida", leitor.Sobrenome);
    }
}
