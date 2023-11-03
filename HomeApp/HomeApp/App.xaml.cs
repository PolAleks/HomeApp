using HomeApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new LoadingPage();
            //MainPage = new SpanPage();
            //MainPage = new LoginPage();
            //MainPage = new RegisterPage();
            //MainPage = new RoomsPage();
            //MainPage = new DevicesPage();
            //MainPage = new ClimatePage();

            MainPage = new GridPage();
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
