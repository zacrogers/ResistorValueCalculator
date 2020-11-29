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

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }

        private void FourBandToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void FiveBandToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FiveBandPage());
        }

        private void SixBandToolbarItem_Activated(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SixBandPage());
        }
    }
}