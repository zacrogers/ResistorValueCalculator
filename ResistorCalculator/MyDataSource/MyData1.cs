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
                Color = Color.FromHex("#000000"),
                Tolerance = 20.0f,
                TempCoeff = 250
            },
            new ResistorBand()
            {
                BandVal = 1,
                BandColour = "#FFA52A2A", // brown
                Color = Color.FromHex("#FFA52A2A"),
                Tolerance = 1.0f,
                TempCoeff = 100
            },
            new ResistorBand()
            {
                BandVal = 2,
                BandColour = "#ff0000", //red
                Color = Color.FromHex("#ff0000"),
                Tolerance = 2.0f,
                TempCoeff = 50
            },
            new ResistorBand()
            {
                BandVal = 3,
                BandColour = "#ffa500", // orange
                Color = Color.FromHex("#ffa500"),
                Tolerance = 3.0f,
                TempCoeff = 15
            },
            new ResistorBand()
            {
                BandVal = 4,
                BandColour = "#ffff00", // yellow
                Color = Color.FromHex("#ffff00"),
                Tolerance = 0.0f,
                TempCoeff = 25
            },
            new ResistorBand()
            {
                BandVal = 5,
                BandColour = "#008000", // green
                Color = Color.FromHex("#008000"),
                Tolerance = 0.5f,
                TempCoeff = 20
            },
            new ResistorBand()
            {
                BandVal = 6,
                BandColour = "#0000ff", // blue
                Color = Color.FromHex("#0000ff"),
                Tolerance = 0.25f,
                TempCoeff = 10
            },
            new ResistorBand()
            {
                BandVal = 7,
                BandColour = "#a834eb", // Purple
                Color = Color.FromHex("#a834eb"),
                Tolerance = 0.10f,
                TempCoeff = 5
            },
            new ResistorBand()
            {
                BandVal = 8,
                BandColour = "#808080", // Gray
                Color = Color.FromHex("#808080"),
                Tolerance = 0.05f,
                TempCoeff = 1
            },
            new ResistorBand()
            {
                BandVal = 9,
                BandColour = "#FFFFFF", // white
                Color = Color.FromHex("#FFFFFF"),
                Tolerance = 10.0f
            }
            /*
            new ResistorBand()
            {
                BandVal = 9,
                BandColour = "#FFFFD700", // gold
            Color = Color.FromHex("#FFFFD700"),
                Tolerance = 10.0f
            },
            new ResistorBand()
            {
                BandVal = 9,
                BandColour = "#c0c0c0", // silver
            Color = Color.FromHex("#c0c0c0"),
                Tolerance = 10.0f
            }
            */
        };
    }
}
