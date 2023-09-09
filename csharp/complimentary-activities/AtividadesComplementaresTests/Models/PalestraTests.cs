using AtividadeComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class PalestraTests
    {
        [TestMethod]
        public void Deve_Criar_Palestra()
        {
            //arrange
            var nome = "Fundamentos de K8s (Kubernetes)";
            var realizacao = DateTime.Now;
            var cargaHoraria = 1;
            var palestrante = "matthew";

            //act
            var palestra = new Palestra(nome, realizacao, cargaHoraria, palestrante);

            //assert
            Assert.IsNotNull(palestra);
            Assert.AreEqual(nome, palestra.Nome);
            Assert.AreEqual(cargaHoraria, palestra.CargaHoraria);
            Assert.AreEqual(realizacao, palestra.Realizacao);
            Assert.AreEqual(palestrante, palestra.Palestrante);
        }
    }
}
