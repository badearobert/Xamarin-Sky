using Sharpnado.Presentation.Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Tab3_Travellers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravellersBasePage : ContentPage
    {
        public TravellersBasePage()
        {
            InitializeComponent();
            
        }

        private void ButtonPress_About(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ProfileTabContentPage());
            /*
            MyStackLayout.Children.Clear();
            MyStackLayout.Children.Add(new Label()
            {
                BackgroundColor = Color.Aqua,
                Text = "from about"
            });*/
        }
    }
}