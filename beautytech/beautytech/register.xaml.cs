using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace beautytech
{
    public partial class register : ContentPage
    {
        public register()
        {
            InitializeComponent();
        }
        private void registerClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}

