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
                BandColour = "Black",
                Tolerance = 20.0f
            },
            new ResistorBand()
            {
                BandVal = 1,
                BandColour = "Brown",
                Tolerance = 1.0f
            },
            new ResistorBand()
            {
                BandVal = 2,
                BandColour = "Red",
                Tolerance = 2.0f
            },
            new ResistorBand()
            {
                BandVal = 3,
                BandColour = "Orange",
                Tolerance = 3.0f
            },
            new ResistorBand()
            {
                BandVal = 4,
                BandColour = "Yellow",
                Tolerance = 0.0f
            },
            new ResistorBand()
            {
                BandVal = 5,
                BandColour = "Green",
                Tolerance = 0.5f
            },
            new ResistorBand()
            {
                BandVal = 6,
                BandColour = "Blue",
                Tolerance = 0.25f
            },
            new ResistorBand()
            {
                BandVal = 7,
                BandColour = "#a834eb",
                Tolerance = 0.10f
            },
            new ResistorBand()
            {
                BandVal = 8,
                BandColour = "#808080",
                Tolerance = 0.05f
            },
            new ResistorBand()
            {
                BandVal = 9,
                BandColour = "White",
                Tolerance = 10.0f
            }
        };

    }
}
