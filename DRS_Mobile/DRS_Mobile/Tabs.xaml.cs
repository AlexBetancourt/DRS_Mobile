using DRS_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace DRS_Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabs : TabbedPage
    {
        readonly Page LanceTab;
        readonly Page WnMTab;
        readonly Page DiagTab;
        readonly Page CompTab;
        readonly Page WpnTab;
        readonly Page HtTab;

        public Tabs()
        {
            InitializeComponent();


            LanceTab = new LanceComposition() { Title = "Lance" };
            WnMTab = new WarriorNMech() { Title = "Warrior & Mech Data" };
            DiagTab = new MechDiagram() { Title = "Mech Diagram" };
            WpnTab = new WeaponsNEquip() { Title = "Weapons & Eq." };
            CompTab = new Components() { Title = "Critial Comp." };
            HtTab = new HeatData() { Title = "Heat Data" };

            this.Children.Add(LanceTab);
            this.Children.Add(WnMTab);
            this.Children.Add(DiagTab);
            this.Children.Add(WpnTab);
            this.Children.Add(CompTab);
            this.Children.Add(HtTab);
           

    }




    }

}