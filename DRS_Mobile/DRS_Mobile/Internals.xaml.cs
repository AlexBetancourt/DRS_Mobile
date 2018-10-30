using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DRS_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Internals : ContentPage
    {
        public Internals()
        {
            InitializeComponent();

           // lvComponents.ItemsSource = mech.mechLocations.Internals.LocationSlotList;
        }

        private void sliHits_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtHits.Text = spHits.Value.ToString();
            switch (int.Parse(txtHits.Text))
            {
                case 1:
                    txtCouns.Text = "3";
                    break;
                case 2:
                    txtCouns.Text = "5";
                    break;
                case 3:
                    txtCouns.Text = "7";
                    break;
                case 4:
                    txtCouns.Text = "10";
                    break;
                case 5:
                    txtCouns.Text = "11";
                    break;
                case 6:
                    txtCouns.Text = "Dead";
                    break;
                default:
                    txtCouns.Text = "0";
                    break;
            }
        }
    }
}