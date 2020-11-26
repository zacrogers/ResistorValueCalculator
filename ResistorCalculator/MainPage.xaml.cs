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
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.FourBandResistorViewModel();
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