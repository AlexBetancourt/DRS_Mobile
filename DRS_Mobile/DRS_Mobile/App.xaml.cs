using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using DRS_Mobile.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DRS_Mobile
{
    public partial class App : Application
    {
        static MechDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new Tabs();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }



        public static MechDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MechDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MechDB.db3"));
                }
                return database;
            }
        }


    }
}
