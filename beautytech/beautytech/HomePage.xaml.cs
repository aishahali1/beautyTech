using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace beautytech
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SalonPage());
        }
    }
}

