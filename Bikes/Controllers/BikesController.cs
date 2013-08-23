using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Bikes.ViewModels;

namespace Bikes.Controllers
{
    public class BikesController : Controller
    {
        //
        // GET: /Bikes/
        [HttpGet]
        public ActionResult SellPersonInfo()
        {
            SellBikeViewModel sellBikeEntity = new SellBikeViewModel();

            return View();
        }

        public string Process(string text)
        {           
            List<char> array = new List<char>();
            array.Add('>');
            int first = text.IndexOfAny(array.ToArray(),0);
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
    }
}
