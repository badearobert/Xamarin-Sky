using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sky.Common.CustomViews
{
    public class SwitchButtonViewModel : INotifyPropertyChanged
    {
        public SwitchButtonViewModel(bool initial_state)
        {
            State = initial_state;
        }
        private string Source_toggled_on = "common_switch_enabled.png";
        private string Source_toggled_off = "common_switch_disabled.png";
        private bool State;

        public event PropertyChangedEventHandler PropertyChanged;

        public string ImageSource => State? Source_toggled_on : Source_toggled_off;


        public void Toggle()
        {
            System.Diagnostics.Debug.WriteLine("OnButtonToggled");
            State = !State;
            OnPropertyChanged(nameof(ImageSource));
        }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
