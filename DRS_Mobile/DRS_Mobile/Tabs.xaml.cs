using DRS_Mobile.Models;
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
    public partial class Tabs : TabbedPage
    {
        public Tabs()
        {
            InitializeComponent();
            this.Children.Add(new Internals() { Title = "Generals" });
            this.Children.Add(new MainPage() { Title = "Damage" });
            this.Children.Add(new Weapons() { Title = "Weapons" });
        }
        public Tabs(TabbedPagesModel model):this()
        {
            

        }

    }

}