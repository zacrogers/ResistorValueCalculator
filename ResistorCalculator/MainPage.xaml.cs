using ResistorCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResistorCalculator
{
    public partial class MainPage : ContentPage
    {
        /*
        public readonly int ScreenHeight = App.ScreenHeight;
        public readonly int ScreenWidth = App.ScreenWidth;

        //public int CurrentResistorValue = 100;

        public int band1Value = 0;
        public int band2Value = 0;
        public int multiplier = 0;
        public float tolerance = 0;

        public string band1Col = string.Empty;
        public string band2Col = string.Empty;
        public string band3Col = string.Empty;
        public string band4Col = string.Empty;
        */

        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.ResistorBandViewModel();

            var model = new ViewModels.FourBandResistorViewModel();

            BindingContext = model;

            //resistorIconLayout.Margin = new Thickness(0, ScreenHeight/10, 0, 0);
            //ResistorValueLabel.Margin = new Thickness(0, 0, 0, ScreenHeight/5);

            //UpdateResistorValueLabel();

            /* Update display label when listview selection happens */
            /*
            ResistorBand1ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                band1Value = item.BandVal;
                band1IconColour.BackgroundColor = Color.FromHex(item.BandColour);
                UpdateResistorValueLabel();
            };
            
            ResistorBand2ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                band2Value = item.BandVal;
                band2IconColour.BackgroundColor = Color.FromHex(item.BandColour);
                UpdateResistorValueLabel();
            };

            ResistorBand3ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                multiplier = item.BandVal;
                band3IconColour.BackgroundColor = Color.FromHex(item.BandColour);
                UpdateResistorValueLabel();
            };

            ResistorBand4ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                //tolerance = (float)item.BandVal;
                tolerance = (float)item.Tolerance;
                band4IconColour.BackgroundColor = Color.FromHex(item.BandColour);
                UpdateResistorValueLabel();
            };
            */
        }

        /*
        private void UpdateResistorValueLabel()
        {
            float resistorVal = (((band1Value * 10.0f) + (band2Value)) / 10.0f) * (float)Math.Pow(10, multiplier);
            string str_end = "\u03A9" + "\u00B1" + $"{tolerance}%"; // "\u03A9" = omega, "\u00B1" = +- 

            if (resistorVal < 1000)
            {
                ResistorValueLabel.Text = (resistorVal).ToString() + str_end;
                return;
            }
            // Giga ohms 
            else if (resistorVal > 999999999)
            {
                resistorVal = resistorVal / 1000000000;
                ResistorValueLabel.Text = (resistorVal).ToString() + "G" + str_end;
                return;
            }
            // Mega ohms 
            else if (resistorVal > 999999)
            {
                resistorVal = resistorVal / 1000000;
                ResistorValueLabel.Text = (resistorVal).ToString() + "M" + str_end;
                return;
            }
            // Kilo ohms 
            else if (resistorVal > 999)
            {
                resistorVal = resistorVal / 1000;
                ResistorValueLabel.Text = (resistorVal).ToString() + "k" + str_end;
                return;
            }
        }
            */

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void FourBandToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void FiveBandToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void SixBandToolbarItem_Activated(object sender, EventArgs e)
        {

        }
    }
}
