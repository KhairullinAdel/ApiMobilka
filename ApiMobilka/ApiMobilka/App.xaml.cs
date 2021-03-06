using ApiMobilka.Services;
using ApiMobilka.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiMobilka
{
    public partial class App : Application
    {
        public static RequestManager RequestManager { get; private set; }

        public App()
        {
            InitializeComponent();

            RequestManager = new RequestManager(new RestService());
            MainPage = new NavigationPage(new EntriesListPage()) { BarBackgroundColor = Color.Red };
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
