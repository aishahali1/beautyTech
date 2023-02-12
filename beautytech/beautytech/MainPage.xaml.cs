using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using beautytech;

namespace beautytech
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_clicked(object sender, EventArgs e)
        {



            if (EmailorPhone.Text == "admin")

            {
                if (txtPass.Text == "123456")
                {

                     Navigation.PushAsync(new HomePage());
                }

            }  else
            {
                DisplayAlert("try again", " Email or Password is incorrect!", "ok");
          
            }
        }
        private void tapped_gesture(object sender, EventArgs e)
        {
            Navigation.PushAsync(new register());
        }
        private void Guesttap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}

 