using AtividadeComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class AtividadeComplementarTests
    {
        [TestMethod]
        public void Deve_Criar_AtividadeComplementar()
        {
            //arrange
            var nome = "Workshop sonarqube";
            var realizacao = DateTime.Now;
            var cargaHoraria = 2;

            //act
            var atividadeComplementar = new AtividadeComplementar(nome, realizacao, cargaHoraria);

            //assert
            Assert.IsNotNull(atividadeComplementar);
            Assert.AreEqual(nome, atividadeComplementar.Nome);
            Assert.AreEqual(cargaHoraria, atividadeComplementar.CargaHoraria);
            Assert.AreEqual(realizacao, atividadeComplementar.Realizacao);
        }
    }
}
