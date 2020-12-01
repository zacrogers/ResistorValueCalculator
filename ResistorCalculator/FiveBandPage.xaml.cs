using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResistorCalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FiveBandPage : ContentPage
    {
        public FiveBandPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.FiveBandResistorViewModel();
        }
    }
}