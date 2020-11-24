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
        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.ResistorBandViewModel();

            var model = new ViewModels.FourBandResistorViewModel();

            BindingContext = model;
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
