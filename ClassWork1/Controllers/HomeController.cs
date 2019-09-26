using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork1.Controllers
{
    public class HomeController : Controller
    {
        SystemContext _db = new SystemContext();
        public ActionResult Index()
        {
            ViewBag.Art = _db.Articles.ToList();
            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Com = _db.Comments.ToList();
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