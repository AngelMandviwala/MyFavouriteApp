using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFavouriteMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyApp : ContentPage
    {
        public UserProfile User { get; set; }

        public MyApp()
        {
            InitializeComponent();

            User = new UserProfile("Angel");
            User.Icon = "NetflixProfile1.jpg";

            BindingContext = this;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            // ImageButton button = sender as ImageButton;

            Navigation.PushAsync(new TabPage());
            
            
        }
    }
}