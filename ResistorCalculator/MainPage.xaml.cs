using ResistorCalculator.Models;
using ResistorCalculator.ViewModels;
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
        FourBandResistorViewModel model;
        string resistorValStr = string.Empty;
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.ResistorBandViewModel();

            model = new ViewModels.FourBandResistorViewModel();

            BindingContext = model;
            /*
            ResistorBand1ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                UpdateResistorVal();
            };
            ResistorBand2ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                UpdateResistorVal();
            };
            ResistorBand3ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                UpdateResistorVal();
            };
            ResistorBand4ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                UpdateResistorVal();
            };
            */
        }
        
        private void UpdateResistorVal()
        {
            int b1 = model.Band1ItemSelected.BandVal;
            int b2 = model.Band2ItemSelected.BandVal;
            int mult = model.Band3ItemSelected.BandVal;
            float tol = model.Band4ItemSelected.Tolerance;

            float resistorVal = (((b1 * 10.0f) + b2) / 10.0f) * (float)Math.Pow(10, mult);
            string returnString = string.Empty;

            if (resistorVal < 1000)
            {
                returnString = $"{resistorVal}";
            }
            /* Giga ohms */
            else if (resistorVal > 999999999)
            {
                returnString = $"{resistorVal / 1000000000} G";
            }
            /* Mega ohms */
            else if (resistorVal > 999999)
            {
                returnString = $"{resistorVal / 1000000} M";
            }
            /* Kilo ohms */
            else if (resistorVal > 999)
            {
                returnString = $"{resistorVal / 1000} k";
            }
            resistorValStr = $"{returnString} \u03A9 \u00B1 {tol}%";
        }

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
