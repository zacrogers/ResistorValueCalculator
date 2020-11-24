using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ResistorCalculator.Models
{
    public class ResistorBand
    {
        public ResistorBand(){ }
        public ResistorBand(int val, Color col, int mult, float tol)
        {
            BandVal = val;
            Color = col;
            Tolerance = tol;
        }

        public int BandVal { get; set; }
        public string BandColour { get; set; }
        public Color Color { get; set; } 
        public string Multiplier { get; set; }
        public float Tolerance { get; set; }
    }
}
