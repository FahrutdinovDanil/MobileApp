using MobileApp.Sql_Lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        Project project;
        public AboutPage(Project newProj)
        {
            InitializeComponent();

            project = newProj;
            projDesc.Text = project.Description;
        }
        public AboutPage()
        {
            InitializeComponent();
        }
    }
}