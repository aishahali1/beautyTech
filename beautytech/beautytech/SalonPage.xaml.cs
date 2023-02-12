using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace beautytech
{
    public partial class SalonPage : ContentPage
    {

        public SalonPage()
        {
            InitializeComponent();
            this.BindingContext = new DisplayList();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Calender());
        }

    }

    public class DisplayList
    {
        public List<Salons> SerSkin { get; set; }
        public List<Salons> SerHairCut { get; set; }
        public List<Salons> SerHairColor { get; set; }
        public List<Salons> SerNails { get; set; }

        public DisplayList()
        {
            SerSkin = new List<Salons>()
            {
                new Salons() {SerId = 1, SerName= "Wax 100SR"},
                new Salons() {SerId= 2, SerName="Classic Facial 185SR"},

            };


            SerHairCut = new List<Salons>()
            {
                new Salons() {SerId = 1, SerName= "Long Hair 100SR"},
                new Salons() {SerId = 2, SerName= "Short Hair 50SR"},
            };

            SerHairColor = new List<Salons>()
            {
                new Salons() {SerId=1, SerName="Highlight 100SR"},
                new Salons() {SerId=2, SerName="Lowlight 150SR"}
            };

            SerNails = new List<Salons>()
            {
                new Salons() {SerId=1, SerName="Nail Art 100SR"},
                new Salons(){SerId=2, SerName="Acrylic 150SR"}
            };

        }
    }

    public class Salons
    {
        public int SerId { get; set; }
        public string SerName { get; set; }

        public override string ToString()
        {
            return "ID: " + SerId + "   Name: " + SerName;
        }

    }


}

