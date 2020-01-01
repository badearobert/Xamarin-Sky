using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sky.Tab3_Travellers.CustomContentView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Tab3_Travellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileTabContentPage : ContentPage
    {
        public ProfileTabContentPage()
        {
            InitializeComponent();
        }

        private void ButtonPress_About(object sender, EventArgs e)
        {
            MyStackLayout.Children.Clear();
            MyStackLayout.Children.Add(new TabAbout_ContentView());
        }

        private void ButtonPress_Favourites(object sender, EventArgs e)
        {
            MyStackLayout.Children.Clear();
            MyStackLayout.Children.Add(new TabFavourites_ContentView());
        }

        private void ButtonPress_Gallery(object sender, EventArgs e)
        {
            MyStackLayout.Children.Clear();
            MyStackLayout.Children.Add(new TabGallery_ContentView());
        }
    }
}