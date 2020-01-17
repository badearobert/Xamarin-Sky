using Sky.Tab3_Travellers.ViewModel;
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
    public partial class MessagesContentPage : ContentPage
    {
        public ProfileDataViewModel VM => ((ProfileDataViewModel)BindingContext);
        public MessagesContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}