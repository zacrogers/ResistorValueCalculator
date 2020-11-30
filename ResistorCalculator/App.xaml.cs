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
            tabbedPage.Children.Add(new MainPage());
            tabbedPage.Children.Add(new FiveBandPage());
            tabbedPage.Children.Add(new SixBandPage());
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
