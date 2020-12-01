using System;
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

    }
}