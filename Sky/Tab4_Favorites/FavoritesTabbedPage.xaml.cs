﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sky.Tab4_Favorites
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesTabbedPage : TabbedPage
    {
        public FavoritesTabbedPage()
        {
            InitializeComponent();
        }
    }
}