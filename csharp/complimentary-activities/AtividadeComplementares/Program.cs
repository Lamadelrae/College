
using AtividadeComplementares.Models;

var palestra = new Palestra("Fundamentos sobre a web", DateTime.Now, 2, "Matthew");
var miniCurso = new MiniCurso("C# para leigos", DateTime.Now, 10, "https://www.contoso.com");
var aluno = new Aluno("Matthew", "email@contoso.com.br");

var registros = new List<Registro>()
{
    new Registro(aluno, palestra),
    new Registro(aluno, miniCurso)
};

registros.ForEach(registro => registro.RegistrarAtividadeComplementar());

try
{
    var palestraDofuturo = new Palestra("Data Science", DateTime.Now.AddHours(10), 10, "Matthew");
    var registro = new Registro(aluno, palestraDofuturo);
    registro.RegistrarAtividadeComplementar();

    registros.Add(registro);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}