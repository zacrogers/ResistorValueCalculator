using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ResistorCalculator.Models
{
    public class ResistorBand
    {
        public ResistorBand(){ }
        public int BandVal { get; set; }
        public string BandColour { get; set; }
        public string Multiplier { get; set; }
        public float Tolerance { get; set; }
        public int TempCoeff { get; set; }
    }
}
