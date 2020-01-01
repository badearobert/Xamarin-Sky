﻿using System;
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
        private enum Page
        {
            About = 0, 
            Favourites = 1,
            Gallery = 2
        };
        public int ColumnSelected { get; set; }
        private Page currentPage = Page.Gallery;
        public ProfileTabContentPage()
        {
            InitializeComponent();
            BindingContext = this;
            LoadContent(Page.About);
        }

        private View Create(Page newPage)
        {
            switch (currentPage)
            {
                case Page.About: return new TabAbout_ContentView();
                case Page.Favourites: return new TabFavourites_ContentView(); 
                case Page.Gallery: return new TabGallery_ContentView(); 
            }
            return null;
        }

        private void LoadContent(Page newPage)
        {
            if (currentPage == newPage) return;
            Togglebutton(currentPage, false);

            currentPage = newPage;
            ColumnSelected = (int)currentPage;
            System.Diagnostics.Debug.WriteLine("Column selected is " + ColumnSelected);
            Togglebutton(currentPage, true);

            MyStackLayout.Children.Clear();
            MyStackLayout.Children.Add(Create(currentPage));
        }

        private void Togglebutton(Page newPage, bool enabled)
        {
            Color newColor = enabled ? Color.White : Color.FromHex("#A648EB");
            switch (newPage)
            {
                case Page.About: { ButtonAbout.TextColor = newColor; break; }
                case Page.Favourites: { ButtonFavourites.TextColor = newColor; break; }
                case Page.Gallery: { ButtonGallery.TextColor = newColor; break; }
            }
        }
        private void ButtonPress_About(object sender, EventArgs e)
        {
            LoadContent(Page.About);
        }

        private void ButtonPress_Favourites(object sender, EventArgs e)
        {
            LoadContent(Page.Favourites);
        }

        private void ButtonPress_Gallery(object sender, EventArgs e)
        {
            LoadContent(Page.Gallery);
        }
    }
}