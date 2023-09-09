using Planos.Models;

var ciclo = new Circulo();
ciclo.ImporCor(Cor.Preto);

ciclo.Pontos.Add(new Ponto(10, 10));
ciclo.Pontos.Add(new Ponto(20, 20));

var areaCiclo = ciclo.ObterArea();
Console.WriteLine(areaCiclo);

var triangulo = new Triangulo();
triangulo.ImporCor(Cor.Branco);

triangulo.Pontos.Add(new Ponto(10, 10));
triangulo.Pontos.Add(new Ponto(20, 20));
triangulo.Pontos.Add(new Ponto(50, 40));

var areaTriangulo = triangulo.ObterArea();
Console.WriteLine(areaTriangulo);

var plano = new Plano();
plano.AttachFigura(ciclo);
plano.DetachFigura();