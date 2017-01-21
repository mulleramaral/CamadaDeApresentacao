using CamadaDeApresentacao.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Editar()
        {
            Aluno aluno = new Aluno
            {
                Id = 1,
                Nome = "Muller caetano do amaral",
                Email = "miilleramaral@gmail.com"
            };

            return View(aluno);
        }

        public ActionResult Detalhes()
        {
            Aluno a = new Aluno
            {
                Id = 1,
                Nome = "Muller caetano do amaral",
                Email = "miilleramaral@gmail.com"
            };
            return View(a);
        }

        public ActionResult Lista()
        {
            ICollection<Aluno> lista = new List<Aluno>();

            for (int i = 0; i < 5; i++)
            {
                Aluno a = new Aluno
                {
                    Id = i,
                    Nome = "Aluno " + i,
                    Email = "Email " + i
                };

                lista.Add(a);
            }

            return View(lista);
        }
    }
}