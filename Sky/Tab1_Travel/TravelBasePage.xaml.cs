using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Tab1_Travel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravelBasePage : ContentPage
    {
        private Hotel myHotel;
        public TravelBasePage()
        {
            InitializeComponent();
            myHotel = new Hotel() { Name = "The Whateeever Hotel", Location = "63 W 38Th St, New York , NY 10018" };
            //Whatever1.BindingContext = myHotel;
            //Whatever2.BindingContext = myHotel;
        }
        public TravelBasePage(string title)
        {
            InitializeComponent();
            Title = title;
        }


    }
}