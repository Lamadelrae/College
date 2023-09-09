using AtividadeComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class AlunoTests
    {
        [TestMethod]
        public void Deve_Criar_Aluno()
        {
            //arrange
            var name = "Matthew";
            var email = "123@gmail.com";

            //act
            var aluno = new Aluno(name, email);

            //assert
            Assert.AreEqual(name, aluno.Nome);
            Assert.AreEqual(email, aluno.Email);
        }
    }
}