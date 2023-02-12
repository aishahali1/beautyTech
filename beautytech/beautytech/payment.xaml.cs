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
        void CheckoutClick(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Appointment booked!", "ok");
            Navigation.PushAsync(new HomePage());
        }
    }
}

