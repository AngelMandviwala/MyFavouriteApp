using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFavouriteMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Color.Black;
            MainPage = navPage;
        }

        protected override async void OnStart()
        {
          //  base.OnStart();
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
