using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.TextToSpeech;
using Plugin.TextToSpeech.Abstractions;

namespace DRS_Mobile
{

    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            stHHP.Maximum = 9;
            stCTHP.Maximum = 25;
            stLTHP.Maximum = 18;
            stRTHP.Maximum = 18;
            stLAHP.Maximum = 12;
            stRAHP.Maximum = 12;
            stLLHP.Maximum = 15;
            stRLHP.Maximum = 15;

            stIHHP.Maximum = 3;
            stICTHP.Maximum = 9;
            stILTHP.Maximum = 5;
            stIRTHP.Maximum = 5;
            stILAHP.Maximum = 3;
            stIRAHP.Maximum = 3;
            stILLHP.Maximum = 4;
            stIRLHP.Maximum = 4;

            lblHHP.Text = stHHP.Maximum.ToString();
            lblCTHP.Text = stCTHP.Maximum.ToString();
            lblLTHP.Text = stLTHP.Maximum.ToString();
            lblRTHP.Text = stRTHP.Maximum.ToString();
            lblLAHP.Text = stLAHP.Maximum.ToString();
            lblRAHP.Text = stRAHP.Maximum.ToString();
            lblLLHP.Text = stLLHP.Maximum.ToString();
            lblRLHP.Text = stRLHP.Maximum.ToString();

            lblIHHP.Text = stHHP.Maximum.ToString();
            lblICTHP.Text = stCTHP.Maximum.ToString();
            lblILTHP.Text = stLTHP.Maximum.ToString();
            lblIRTHP.Text = stRTHP.Maximum.ToString();
            lblILAHP.Text = stLAHP.Maximum.ToString();
            lblIRAHP.Text = stRAHP.Maximum.ToString();
            lblILLHP.Text = stLLHP.Maximum.ToString();
            lblIRLHP.Text = stRLHP.Maximum.ToString();


            stHHP.Value = stHHP.Maximum;
            stCTHP.Value = stCTHP.Maximum;
            stLTHP.Value = stLTHP.Maximum;
            stRTHP.Value = stRTHP.Maximum;
            stLAHP.Value = stLAHP.Maximum;
            stRAHP.Value = stRAHP.Maximum;
            stLLHP.Value = stLLHP.Maximum;
            stRLHP.Value = stRLHP.Maximum;

            stIHHP.Value = stHHP.Maximum;
            stICTHP.Value = stCTHP.Maximum;
            stILTHP.Value = stLTHP.Maximum;
            stIRTHP.Value = stRTHP.Maximum;
            stILAHP.Value = stLAHP.Maximum;
            stIRAHP.Value = stRAHP.Maximum;
            stILLHP.Value = stLLHP.Maximum;
            stIRLHP.Value = stRLHP.Maximum;

            stIHHP.IsVisible = 
            stICTHP.IsVisible = 
            stILTHP.IsVisible = 
            stIRTHP.IsVisible = 
            stILAHP.IsVisible = 
            stIRAHP.IsVisible = 
            stILLHP.IsVisible = 
            stIRLHP.IsVisible = false;
            lblIHHP.IsVisible =
            lblICTHP.IsVisible =
            lblILTHP.IsVisible =
            lblIRTHP.IsVisible =
            lblILAHP.IsVisible =
            lblIRAHP.IsVisible =
            lblILLHP.IsVisible =
            lblIRLHP.IsVisible = false;

        }

        void OnValueChangedH(object sender, ValueChangedEventArgs e)
        {
            pbHeat.Progress = e.NewValue / stHHP.Maximum;
            lblHHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblHHP, null, lblHHP, "HHHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblHHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stHHP.Maximum.ToString()) / 3))
            {

                lblHHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stHHP.Maximum.ToString()) / 3) * 2)
            {
                lblHHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblHHP.BackgroundColor = Color.White;
            }
        }

        private void stCTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblCTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblCTHP, null, lblCTHP, "CTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblCTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stCTHP.Maximum.ToString()) / 3))
            {

                lblCTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stCTHP.Maximum.ToString()) / 3) * 2)
            {
                lblCTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblCTHP.BackgroundColor = Color.White;
            }
        }

        private void stLTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLTHP, null, lblLTHP, "LTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLTHP.Maximum.ToString()) / 3))
            {

                lblLTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLTHP.Maximum.ToString()) / 3) * 2)
            {
                lblLTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLTHP.BackgroundColor = Color.White;
            }
        }

        private void stRTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRTHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRTHP, null, lblRTHP, "RTHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRTHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRTHP.Maximum.ToString()) / 3))
            {

                lblRTHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRTHP.Maximum.ToString()) / 3) * 2)
            {
                lblRTHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRTHP.BackgroundColor = Color.White;
            }
        }

        private void stLAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLAHP, null, lblLAHP, "LAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLAHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLAHP.Maximum.ToString()) / 3))
            {

                lblLAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLAHP.Maximum.ToString()) / 3) * 2)
            {
                lblLAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLAHP.BackgroundColor = Color.White;
            }
        }

        private void stRAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRAHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRAHP, null, lblRAHP, "RAHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRAHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRAHP.Maximum.ToString()) / 3))
            {

                lblRAHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRAHP.Maximum.ToString()) / 3) * 2)
            {
                lblRAHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRAHP.BackgroundColor = Color.White;
            }
        }

        private void stLLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblLLHP, null, lblLLHP, "LLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblLLHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLLHP.Maximum.ToString()) / 3))
            {

                lblLLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stLLHP.Maximum.ToString()) / 3) * 2)
            {
                lblLLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblLLHP.BackgroundColor = Color.White;
            }
        }

        private void stRLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblRLHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblRLHP, null, lblRLHP, "RLHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblRLHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRLHP.Maximum.ToString()) / 3))
            {

                lblRLHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stRLHP.Maximum.ToString()) / 3) * 2)
            {
                lblRLHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblRLHP.BackgroundColor = Color.White;
            }
        }

        private void Button_Clicked(object sender, EventArgs e, object Control, string Location)
        {
            string Ubicacion = "";
            switch (Location.Substring(0, 3))
            {
                case "HHH":
                    Ubicacion = "Head";
                    break;
                case "CTH":
                    Ubicacion = "Center Torso";
                    break;
                case "LTH":
                    Ubicacion = "Left Torso";
                    break;
                case "RTH":
                    Ubicacion = "Right Torso";
                    break;
                case "LAH":
                    Ubicacion = "Left Arm";
                    break;
                case "RAH":
                    Ubicacion = "Right Arm";
                    break;
                case "LLH":
                    Ubicacion = "Left Leg";
                    break;
                case "RLH":
                    Ubicacion = "Right Leg";
                    break;
                case "IHH":
                    Ubicacion = "Internal Head";
                    break;
                case "ICT":
                    Ubicacion = "Internal Center Torso";
                    break;
                case "ILT":
                    Ubicacion = "Internal Left Torso";
                    break;
                case "IRT":
                    Ubicacion = "Internal Right Torso";
                    break;
                case "ILA":
                    Ubicacion = "Internal Left Arm";
                    break;
                case "IRA":
                    Ubicacion = "Internal Right Arm";
                    break;
                case "ILL":
                    Ubicacion = "Internal Left Leg";
                    break;
                case "IRL":
                    Ubicacion = "Internal Right Leg";
                    break;
                default:
                    Ubicacion = "";
                    break;
            }
            var text = (Label)Control;
            if (text.Text == "0" && Ubicacion.Substring(0, 1) != "I")
            {
                text.Text = Ubicacion + " Armor Breached!";
                string Speech = text.Text;
                CrossTextToSpeech.Current.Speak(Speech);
            }
            else if (text.Text == "0" && Ubicacion.Substring(0, 1) == "I")
            {
                text.Text = Ubicacion + " Destroyed!";
                string Speech = text.Text;
                CrossTextToSpeech.Current.Speak(Speech);
            }


        }

        private void stIHHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            pbHeat.Progress = e.NewValue / stIHHP.Maximum;
            lblIHHP.Text = string.Format("{0}", e.NewValue.ToString());
            Button_Clicked(lblIHHP, null, lblIHHP, "IHHP");
            if (int.Parse(e.NewValue.ToString()) == 0)
            {
                lblIHHP.BackgroundColor = Color.LightGray;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIHHP.Maximum.ToString()) / 3))
            {

                lblIHHP.BackgroundColor = Color.Red;
            }
            else if (int.Parse(e.NewValue.ToString()) <= (int.Parse(stIHHP.Maximum.ToString()) / 3) * 2)
            {
                lblIHHP.BackgroundColor = Color.Yellow;
            }
            else
            {
                lblIHHP.BackgroundColor = Color.White;
            }
        }

        private void stICTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stILTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stIRTHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stILAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stIRAHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stILLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void stIRLHP_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }

}
