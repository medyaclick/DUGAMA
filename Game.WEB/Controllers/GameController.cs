using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.WEB.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Response.Write("fitsr");
            return View();
        }
        public ActionResult Play(string id)
        {
            return View();
        }
    }
}