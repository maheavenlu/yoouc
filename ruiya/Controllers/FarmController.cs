using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ruiya.Controllers
{
    public class FarmController : Controller
    {
        // GET: Farm
        /*public ActionResult Index()
        {
            return View();
        }*/
        [Route("ruiya/happyFamily")]
        public ActionResult GetHappyFamilyPage()
        {
            return View("HappyFamilyPage");
        }

        [Route("ruiya/happyFamilyHelp")]
        public ActionResult GetHappyFamilyHelpPage()
        {
            return View("HappyFamilyHelpPage");
        }
    }
}