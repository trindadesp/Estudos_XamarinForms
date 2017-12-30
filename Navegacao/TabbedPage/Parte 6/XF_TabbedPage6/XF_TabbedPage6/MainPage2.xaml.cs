﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_TabbedPage6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage3());
        }
    }
}