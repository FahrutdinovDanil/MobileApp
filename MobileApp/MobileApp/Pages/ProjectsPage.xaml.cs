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
    public partial class ProjectsPage : ContentPage
    {
        public ProjectsPage()
        {
            this.BindingContext = this;

            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            projectList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            ProjectPage projectPage = new ProjectPage(selectedProject);
            await Navigation.PushAsync(projectPage);
        }

        private async void CreateProject(object sender, EventArgs e)
        {
            Project proj = new Project();
            AddProject projPage = new AddProject();
            projPage.BindingContext = proj;
            await Navigation.PushAsync(projPage);
        }
    }
}