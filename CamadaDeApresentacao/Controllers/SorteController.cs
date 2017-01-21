using System;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class SorteController : Controller
    {
        public ActionResult Index()
        {
            Random random = new Random();
            ViewBag.NumeroDaSorte = random.Next();
            return View();
        }
    }
}