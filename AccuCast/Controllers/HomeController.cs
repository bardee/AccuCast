using AccuCast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccuCast.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(InstallModel model)
        {
            if (ModelState.IsValid) {
                TempData["notice"] = "Thank you for installing AccuCast!";
                TempData["zipVal"] = model.zip;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}