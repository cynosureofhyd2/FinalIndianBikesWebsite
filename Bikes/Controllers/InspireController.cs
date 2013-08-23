using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bikes.Controllers
{
    public class InspireController : Controller
    {
        //
        // GET: /Inspire/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CallBikesWeb()
        {
            return View();
        }
    }
}
