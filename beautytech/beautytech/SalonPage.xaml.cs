using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace beautytech
{
    public partial class SalonPage : ContentPage
    {
        public int SerId { get; set; }

        public string SerName { get; set; }


        public IList<SalonPage> SerSkin { get; set; }
        public IList<SalonPage> SerHairCut { get; set; }
        public IList<SalonPage> SerHairColor { get; set; }
        public IList<SalonPage> SerNails { get; set; }

        public SalonPage()
        {
            InitializeComponent();

            SerSkin = new ObservableCollection<SalonPage>();

            SerSkin.Add(new SalonPage { SerId = 1, SerName = "Wax 100SR" });
            SerSkin.Add(new SalonPage { SerId = 2, SerName = "Classic Facial 185SR" });
            SerSkin.Add(new SalonPage { SerId = 3, SerName = "Skin" });


            SerHairCut = new ObservableCollection<SalonPage>();

            SerHairCut.Add(new SalonPage { SerId = 1, SerName = "Long Hair 100SR" });
            SerHairCut.Add(new SalonPage { SerId = 2, SerName = "Short Hair 50SR" });


            SerHairColor = new ObservableCollection<SalonPage>();

            SerHairColor.Add(new SalonPage { SerId = 1, SerName = "Highlight 100SR" });
            SerHairColor.Add(new SalonPage { SerId = 2, SerName = "Lowlight 150SR" });

            SerNails = new ObservableCollection<SalonPage>();

            SerNails.Add(new SalonPage { SerId = 1, SerName = "Nail Art 100SR" });
            SerNails.Add(new SalonPage { SerId = 2, SerName = "Acrylic 150SR" });


        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Calender());
        }

    }
        
    }


