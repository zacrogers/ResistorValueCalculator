using ResistorCalculator.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ResistorCalculator.MyDataSource
{
    public class MyData1
    {
        public List<ResistorBand> Band1Vals = new List<ResistorBand>()
        { 
            new ResistorBand()
            { 
                BandVal = 0,
                BandColour = "#000000", // black
                Tolerance = 20.0f,
                TempCoeff = 250
            },
            new ResistorBand()
            {
                BandVal = 1,
                BandColour = "#FFA52A2A", // brown
                Tolerance = 1.0f,
                TempCoeff = 100
            },
            new ResistorBand()
            {
                BandVal = 2,
                BandColour = "#ff0000", //red
                Tolerance = 2.0f,
                TempCoeff = 50
            },
            new ResistorBand()
            {
                BandVal = 3,
                BandColour = "#ffa500", // orange
                Tolerance = 3.0f,
                TempCoeff = 15
            },
            new ResistorBand()
            {
                BandVal = 4,
                BandColour = "#ffff00", // yellow
                Tolerance = 0.0f,
                TempCoeff = 25
            },
            new ResistorBand()
            {
                BandVal = 5,
                BandColour = "#008000", // green
                Tolerance = 0.5f,
                TempCoeff = 20
            },
            new ResistorBand()
            {
                BandVal = 6,
                BandColour = "#0000ff", // blue
                Tolerance = 0.25f,
                TempCoeff = 10
            },
            new ResistorBand()
            {
                BandVal = 7,
                BandColour = "#a834eb", // Purple
                Tolerance = 0.10f,
                TempCoeff = 5
            },
            new ResistorBand()
            {
                BandVal = 8,
                BandColour = "#808080", // Gray
                Tolerance = 0.05f,
                TempCoeff = 1
            },
            new ResistorBand()
            {
                BandVal = 9,
                BandColour = "#FFFFFF", // white
                Tolerance = 10.0f
            },
            new ResistorBand()
            {
                BandColour = "#FFFFD700", // gold
                Tolerance = 0.1f
            },
            new ResistorBand()
            {
                BandColour = "#c0c0c0", // silver
                Tolerance = 0.01f
            }
        };
    }
}
