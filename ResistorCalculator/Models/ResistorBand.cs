using System;
using System.Collections.Generic;
using System.Text;

namespace ResistorCalculator.Models
{
    public class ResistorBand
    {
        public int BandVal { get; set; }
        public string BandColour { get; set; }
        public string Multiplier { get; set; }
        public float Tolerance { get; set; }
    }
}
