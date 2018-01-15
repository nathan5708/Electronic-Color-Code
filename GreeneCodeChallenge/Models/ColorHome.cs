using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreeneCodeChallenge.Models
{
    public class ColorHome
    {
        public string BandAColor { get; set; }
        public string BandBColor { get; set; }
        public string BandCColor { get; set; }
        public string BandDColor { get; set; }
        public SelectList Colors { get; set; }
        public string result { get; set; }
        public string tolerance { get; set; }
    }

}