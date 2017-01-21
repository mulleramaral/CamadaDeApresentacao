using CamadaDeApresentacao.Models;
using System;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Editar()
        {
            Usuario usuario = new Usuario
            {
                Id = 1,
                Nome = "Muller caetano",
                Email = "miilleramaral@gmail.com",
                Senha = "123",
                Descricao = "Sócio-fundador da K19 / Instrutor",
                DataDeCadastro = DateTime.Now
            };

            return View(usuario);
        }
    }
}