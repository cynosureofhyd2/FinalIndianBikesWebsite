using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bikes.Controllers
{
    public class HomeController : Controller
    {

        private BikesEntities db = new BikesEntities();


        public ActionResult Final()
        {
            return View();
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            string[] text;
            BikesEntities db = new BikesEntities();
            Place bikeBrand;
            try
            {
                bikeBrand = new Place();
                text = System.IO.File.ReadAllLines(@"C:\Users\Cynosure\APPlaces.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
       
           return RedirectToAction("Bikes", "Edit");
            //return View();
        }

        public string Process(string text)
        {

            List<char> array = new List<char>();
            array.Add('>');
            int first = text.IndexOfAny(array.ToArray(), 0);
            int end = text.IndexOf("</");
            string temp = string.Empty;
            if (first != -1 || end != -1)
            {
                temp = text.Substring(first + 1, end - first - 1);
                return temp;
            }
            else
                return "";
            //return false;
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult List()
        {   
            return View(db.UsedBikes.ToList());
        }

        public ActionResult Delete(int id)
        {
            UsedBike bike = db.UsedBikes.Find(id);
            return View(db.UsedBikes.ToList());
        }

        [HttpPost]
        public ActionResult Create(UsedBike bike)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.UsedBikes.Add(bike);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(bike);
        }


        public ActionResult AnotherView()
        {
            return View();
        }

        public ActionResult Placeholder()
        {
            return View();
        }

        public ActionResult Dropdown()
        {
            return View();
        }
    }
}
