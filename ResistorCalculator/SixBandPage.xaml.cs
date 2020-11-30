using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResistorCalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SixBandPage : ContentPage
    {
        public SixBandPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.SixBandResistorViewModel();
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
            Navigation.PushAsync(new SixBandPage());
        }
    }
}