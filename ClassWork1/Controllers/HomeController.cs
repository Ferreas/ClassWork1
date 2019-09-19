using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }
 
        [HttpGet]
        public ActionResult Quests()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quests(string name, string gender, string[] pet)
        {
            ViewBag.Text = "Исходя из вашей анкеты:";
            ViewBag.Name = name;
            ViewBag.Gender = gender;
            ViewBag.Pets = String.Join(" и ", pet.Select(p => p.ToString()));
            return View("~/Views/Project/ShowAnswers.cshtml");
        }
    }
}