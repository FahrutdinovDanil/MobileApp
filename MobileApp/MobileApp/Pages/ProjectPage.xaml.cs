using MobileApp.Pages;
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
    public partial class ProjectPage : TabbedPage
    {
        Project project;
        public ProjectPage(Project newProj)
        {
            InitializeComponent();

            project = newProj;
            proj_title.Text = project.Name;
        }
        private async void Edit_Clicked(object sender, EventArgs e)
        {
            EditProject editProjectPage = new EditProject(project);
            await Navigation.PushAsync(editProjectPage);
        }
    }
}