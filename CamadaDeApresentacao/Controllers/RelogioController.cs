using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamadaDeApresentacao.Controllers
{
    public class RelogioController : Controller
    {
        public ActionResult Agora()
        {
            ViewBag.Agora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return View();
        }
    }
}