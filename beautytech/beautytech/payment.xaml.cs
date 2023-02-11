using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace beautytech
{
    public partial class payment : ContentPage
    {
        public payment()
        {
            InitializeComponent();
        }
        private void CheckoutClick(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Appointment booked!", "ok");
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}

