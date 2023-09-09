using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class InstituicaoController : Controller
    {
        private static readonly IList<Instituicao> _instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                Id = 1,
                Nome = "FOA",
                Endereco = "Longe"
            },
            new Instituicao()
            {
                Id = 2,
                Nome = "UGB",
                Endereco = "Aterrado"
            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(_instituicoes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Instituicao instituicao)
        {
            instituicao.Id = _instituicoes.Select(i => i.Id).Max() + 1;

            _instituicoes.Add(instituicao);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_instituicoes.Where(i => i.Id == id).First());
        }

        [HttpPost]
        public IActionResult Edit(Instituicao instituicao)
        {
            _instituicoes.Remove(_instituicoes.Where(i => i.Id == instituicao.Id).First());
            _instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_instituicoes.Where(i => i.Id == id).First());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_instituicoes.Where(i => i.Id == id).First());
        }

        [HttpPost] //wrong method but for the sake of the project.. i'll be using this
        public IActionResult Delete(Instituicao instituicao)
        {
            _instituicoes.Remove(_instituicoes.Where(i => i.Id == instituicao.Id).First());
            return RedirectToAction("Index");
        }
    }
}
