using System;
using Test_CI_Mobile.Services;
using Test_CI_Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_CI_Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
