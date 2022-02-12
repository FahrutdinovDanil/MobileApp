using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using MobileApp.Sqlite;

namespace MobileApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "images.db";
        public static ImagesRepository database;
        public static ImagesRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ImagesRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ImagesList());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
