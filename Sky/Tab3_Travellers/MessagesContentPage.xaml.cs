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
        public MessagesContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}