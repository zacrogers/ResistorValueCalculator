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

    }
}