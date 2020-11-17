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
        public int CurrentResistorValue = 100;

        public int band1Value = 0;
        public int band2Value = 0;
        public int multiplier = 0;
        public float tolerance = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ResistorBandViewModel();
            
            /* Update display label when listview selection happens */
            ResistorBand1ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                band1Value = item.BandVal;
                UpdateResistorValueLabel();
            };

            ResistorBand2ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                band2Value = item.BandVal;
                UpdateResistorValueLabel();
            };

            ResistorBand3ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                multiplier = item.BandVal;
                UpdateResistorValueLabel();
            };

            ResistorBand4ListView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ResistorBand)e.SelectedItem;
                tolerance = (float)item.BandVal;
                UpdateResistorValueLabel();
            };
        }

        private void UpdateResistorValueLabel()
        {
            long resistorVal = ((band1Value * 10) + (band2Value)) * (int)Math.Pow(10, multiplier);

            if (resistorVal < 1000)
            {
                ResistorValue.Text = (resistorVal).ToString() + "\u00B1" + $"{tolerance}%";
                return;
            }
            if (resistorVal > 999999)
            {
                resistorVal = resistorVal / 1000000;
                ResistorValue.Text = (resistorVal).ToString() + "M" + "\u00B1" + $"{tolerance}%";
                return;
            }
            else if (resistorVal > 999)
            {
                resistorVal = resistorVal / 1000;
                ResistorValue.Text = (resistorVal).ToString() + "k" + "\u00B1" + $"{tolerance}%";
                return;
            }


        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }
    }
}
