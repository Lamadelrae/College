using AtividadeComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class MiniCursoTests
    {
        [TestMethod]
        public void Deve_Criar_MiniCurso()
        {
            //arrange
            var nome = "Fundamentos de páginas webs";
            var realizacao = DateTime.Now;
            var cargaHoraria = 10;
            var urlCertificado = "https://contoso.com";

            //act
            var miniCurso = new MiniCurso(nome, realizacao, cargaHoraria, urlCertificado);

            //assert
            Assert.IsNotNull(miniCurso);
            Assert.AreEqual(nome, miniCurso.Nome);
            Assert.AreEqual(cargaHoraria, miniCurso.CargaHoraria);
            Assert.AreEqual(realizacao, miniCurso.Realizacao);
            Assert.AreEqual(urlCertificado, miniCurso.UrlCertificado);
        }
    }
}
