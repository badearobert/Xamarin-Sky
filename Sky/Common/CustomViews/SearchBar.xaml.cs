using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Common.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBar : ContentView
    {
        private SearchBarViewModel viewModel = new SearchBarViewModel();
        public SearchBar()
        {
            InitializeComponent();
            SearchTextParent.BindingContext = viewModel;
        }
    }
}