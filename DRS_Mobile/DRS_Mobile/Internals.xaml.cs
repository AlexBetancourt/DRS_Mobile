using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DRS_Mobile.Data;
using DRS_Mobile.Models;

namespace DRS_Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Internals : ContentPage
	{
		public Internals ()
		{
			InitializeComponent ();

            Mech Mech1 = new Mech();
            Mech1.mechLocations.Armor.CTArmor = 35;
            Mech1.mechLocations.Internals.CTInternal = 18;
            ForceMechs forceMechs = new ForceMechs();



        }
	}
}