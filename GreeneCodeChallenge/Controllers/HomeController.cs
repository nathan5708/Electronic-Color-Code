using GreeneCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreeneCodeChallenge.Controllers
{
    public class HomeController : Controller
    {
         [HttpGet]
        public ActionResult Index(string result, string tolerance, string bandAColor, 
             string bandBColor, string bandCColor, string bandDColor)
        {
            var resistor = new Resistor();
            var model = new ColorHome();
            model.Colors = new SelectList(resistor.Colors.Select(color => new SelectListItem
            {
                Selected = false,
                Text = color.Name,
                Value = color.Name
            }), "Value", "Text", 1);
            model.result = result;
            model.tolerance = tolerance;
            model.BandAColor = bandAColor;
            model.BandBColor = model.BandBColor;
            model.BandCColor = model.BandCColor;
            model.BandDColor = model.BandDColor;
            return View(model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            var cal = new OhmCalculator();

            var value = cal.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            return RedirectToAction("Index", new {
                result = value.OhmValue, 
                tolerance = value.Tolerance,
                bandAColor = bandAColor,
                bandBColor = bandBColor,
                bandCColor = bandCColor,
                bandDColor = bandDColor,
            });
  
}


}
}
