using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        }

        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(args);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new payment());
        }
    }
}

