using Sky.Common;
using Sky.Common.CustomViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Tab2_Discover
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FullPlaceContentPage : ContentPage
    {
        SwitchButtonViewModel viewModel = new SwitchButtonViewModel("tab2_discover_places_button_favorites_remove.png", "tab2_discover_places_button_favorites_add.png", false);
        public FullPlaceContentPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            SwitchButtonFavorite.BindingContext = viewModel;
            SwitchButtonFavorite.OnSwitchPressed += SwitchPressedFavourite;
        }

        private void ButtonPressed_BookPlace(object sender, EventArgs e)
        {
            PopupHelper.ShowAlertDialog("TravelBasePage", "Button pressed - Book place", this);
        }

        private void ButtonPressed_DatePicker(object sender, EventArgs e)
        {
            PopupHelper.ShowAlertDialog("TravelBasePage", "Button pressed - Pick a date", this);
        }

        private void ButtonPressed_AddFavorite(object sender, EventArgs e)
        {
            PopupHelper.ShowAlertDialog("TravelBasePage", "Button pressed - Add favorite", this);
        }
        private void SwitchPressedFavourite(object sender, EventArgs e)
        {
            viewModel.Toggle();
        }
    }
}