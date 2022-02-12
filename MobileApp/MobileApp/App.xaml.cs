using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using MobileApp.Sql_Lite;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Fonts")]
namespace MobileApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "projects.db";
        public static ProjectsRepository database;
        public static ProjectsRepository Database
        {
            get
              
            {  if (database == null)
                {
                    database = new ProjectsRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthorizationPage());
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
