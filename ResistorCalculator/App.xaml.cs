using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResistorCalculator
{
    public partial class App : Application
    {
        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            var tabbedPage = new TabbedPage();
            var mainPage = new MainPage();
            var fiveBand = new FiveBandPage();
            var sixBand = new SixBandPage();

            mainPage.Title = "Four Band";
            fiveBand.Title = "Five Band";
            sixBand.Title = "Six Band";

            tabbedPage.Children.Add(mainPage);
            tabbedPage.Children.Add(fiveBand);
            tabbedPage.Children.Add(sixBand);
            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
