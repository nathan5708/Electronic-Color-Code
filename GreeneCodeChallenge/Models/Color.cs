using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreeneCodeChallenge.Models
{
    public class Color
    {
        public string Name { get; set; }
        public double BandAColor { get; set; }
        public double BandBColor { get; set; }
        public double BandCColor { get; set; }
        public double BandDColor { get; set; }

    }
    public class Resistor
    {
        public List<Color> Colors { get; set; }

        public Resistor()
        {
            Colors = new List<Color>();

            Colors.Add(new Color()
            {
                Name = "Black",
                BandAColor = 0,
                BandBColor = 0,
                BandCColor = 1,
                BandDColor = 0
            });
            Colors.Add(new Color()
            {
                Name = "Brown",
                BandAColor = 1,
                BandBColor = 1,
                BandCColor = 10,
                BandDColor = 1
            });
            Colors.Add(new Color()
            {
                Name = "Red",
                BandAColor = 2,
                BandBColor = 2,
                BandCColor = 100,
                BandDColor = 2
            });
            Colors.Add(new Color()
            {
                Name = "Orange",
                BandAColor = 3,
                BandBColor = 3,
                BandCColor = 1000,
                BandDColor = 0
            });
            Colors.Add(new Color()
            {
                Name = "Yellow",
                BandAColor = 4,
                BandBColor = 4,
                BandCColor = 10000,
                BandDColor = 5
            });
            Colors.Add(new Color()
            {
                Name = "Green",
                BandAColor = 5,
                BandBColor = 5,
                BandCColor = 100000,
                BandDColor = .5
            });
            Colors.Add(new Color()
            {
                Name = "Blue",
                BandAColor = 6,
                BandBColor = 6,
                BandCColor = 1000000,
                BandDColor = .25
            });
            Colors.Add(new Color()
            {
                Name = "Violet",
                BandAColor = 7,
                BandBColor = 7,
                BandCColor = 10000000,
                BandDColor = .1
            });
            Colors.Add(new Color()
            {
                Name = "Gray",
                BandAColor = 8,
                BandBColor = 8,
                BandCColor = 100000000,
                BandDColor = .05
            });
            Colors.Add(new Color()
            {
                Name = "White",
                BandAColor = 9,
                BandBColor = 9,
                BandCColor = 1000000000,
                BandDColor = 0
            });
        }
    }

}