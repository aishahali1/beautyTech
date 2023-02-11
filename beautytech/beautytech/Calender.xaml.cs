using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace beautytech
{
    public partial class Calender : ContentPage
    {
        public Calender()
        {
            InitializeComponent();
        }
        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            MainLabel.Text = e.NewDate.ToLongDateString();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new payment());
        }
    }
}

