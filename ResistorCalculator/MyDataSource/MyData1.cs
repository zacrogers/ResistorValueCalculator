using System;
using System.Collections.Generic;
using System.Text;
using ResistorCalculator.Models;

namespace ResistorCalculator.MyDataSource
{
    public class MyData1
    {
        public List<ResistorBand> Band1Vals = new List<ResistorBand>()
        { 
            new ResistorBand()
            { 
                BandVal = 0,
                BandColour = "Black"
            },
            new ResistorBand()
            {
                BandVal = 1,
                BandColour = "Brown"
            },
            new ResistorBand()
            {
                BandVal = 2,
                BandColour = "Red"
            },
            new ResistorBand()
            {
                BandVal = 3,
                BandColour = "Orange"
            }
        };

    }
}
