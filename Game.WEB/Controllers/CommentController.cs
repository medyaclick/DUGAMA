using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game.WEB.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            List<Game.Domain.Game> list = new List<Domain.Game>();
            list.Add(new Game.Domain.Game { Name = "uğur" });
            list.Add(new Game.Domain.Game { Name = "doğan" });

            ViewBag.popularGames = list;
            return View(list);
        }
    }
}