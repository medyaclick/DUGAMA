using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game.BUS;
using Game.Domain;

namespace Game.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                GameOperations game = GameOperations.Initilize();
                List<Game.Domain.Game> ob = game.Get(2501);

                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}