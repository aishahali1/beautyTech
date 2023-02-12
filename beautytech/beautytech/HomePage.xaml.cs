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
         async void Button_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new SalonPage());
        }
    }
}

