using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreeneCodeChallenge.Models
{
    public class OhmCalculator : IOhmValueCalculator
    {

        public CalculationResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            var resistor = new Resistor();
            var bandA = resistor.Colors.Find(color => color.Name == bandAColor).BandAColor;
            var bandB = resistor.Colors.Find(color => color.Name == bandBColor).BandBColor;
            var bandC = resistor.Colors.Find(color => color.Name == bandCColor).BandCColor;
            var bandD = resistor.Colors.Find(color => color.Name == bandDColor).BandDColor;
            double ohmValue = ((bandA * 10) + bandB) * (bandC);

            var result = new CalculationResult();
            result.OhmValue = ohmValue;
            result.Tolerance = bandD;
            return result;
        }
    }

    public interface IOhmValueCalculator
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        CalculationResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }
    public class CalculationResult 
    {
        public double OhmValue { get; set; }
        public double Tolerance { get; set; }

    }
}