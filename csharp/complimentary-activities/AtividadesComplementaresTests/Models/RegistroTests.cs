using AtividadeComplementares.Models;

namespace AtividadesComplementaresTests.Models
{
    [TestClass]
    public class RegistroTests
    {
        [TestMethod]
        public void Deve_Criar_Registro_ComAtividadeComplementar()
        {
            //arrange
            var aluno = new Aluno("Matthew", "123@gmail.com");
            var atividadeComplementar = new AtividadeComplementar("Fundamentos SQL", DateTime.Now, 2);

            //act
            var registro = new Registro(aluno, atividadeComplementar);

            //assert
            Assert.IsNotNull(registro);
            Assert.AreEqual(aluno, registro.Aluno); // mesma referência
            Assert.AreEqual(atividadeComplementar, registro.AtividadeComplementar); // mesma referência
            Assert.IsTrue(registro.DataValidacao <= DateTime.Now);
        }

        [TestMethod]
        public void Deve_Criar_Registro_ComPalestra()
        {
            //arrange
            var aluno = new Aluno("Matthew", "123@gmail.com");
            var palestra = new Palestra("Fundamentos SQL", DateTime.Now, 2, "Matthew");

            //act
            var registro = new Registro(aluno, palestra);

            //assert
            Assert.IsNotNull(registro);
            Assert.AreEqual(aluno, registro.Aluno); // mesma referência
            Assert.AreEqual(palestra, registro.AtividadeComplementar); // mesma referência
            Assert.IsTrue(registro.DataValidacao <= DateTime.Now);
        }

        [TestMethod]
        public void Deve_Criar_Registro_ComMiniCurso()
        {
            //arrange
            var aluno = new Aluno("Matthew", "123@gmail.com");
            var miniCurso = new MiniCurso("Fundamentos SQL", DateTime.Now, 2, "Matthew");

            //act
            var registro = new Registro(aluno, miniCurso);

            //assert
            Assert.IsNotNull(registro);
            Assert.AreEqual(aluno, registro.Aluno); // mesma referência
            Assert.AreEqual(miniCurso, registro.AtividadeComplementar); // mesma referência
            Assert.IsTrue(registro.DataValidacao <= DateTime.Now);
        }

        [TestMethod]
        public void Deve_Criar_Registro_E_Jogar_Exception()
        {
            //arrange
            var aluno = new Aluno("Matthew", "123@gmail.com");
            var atividadeComplementar = new AtividadeComplementar("Fundamentos SQL", DateTime.Now.AddDays(2), 2);

            //act
            var registro = new Registro(aluno, atividadeComplementar);
            var action = () => registro.RegistrarAtividadeComplementar();

            //assert
            Assert.IsNotNull(registro);
            Assert.AreEqual(aluno, registro.Aluno); // mesma referência
            Assert.AreEqual(atividadeComplementar, registro.AtividadeComplementar); // mesma referência
            Assert.ThrowsException<InvalidOperationException>(action, "Data de validação não pode ser anterior a de realização.");
        }
    }
}
