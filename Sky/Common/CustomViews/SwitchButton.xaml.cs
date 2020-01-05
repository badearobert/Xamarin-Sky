
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
    public partial class SwitchButton : ContentView
    {
        SwitchButtonViewModel viewModel = new SwitchButtonViewModel(false);
        public SwitchButton()
        {
            InitializeComponent();
            BindingContext = viewModel;  
        }

        private void SwitchPressed(object sender, EventArgs e)
        {
            viewModel.Toggle();
        }
    }
}