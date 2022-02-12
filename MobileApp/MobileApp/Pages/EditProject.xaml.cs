using MobileApp.Sql_Lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProject : ContentPage
    {
        Project project;
        public EditProject()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите удалить {project.Name}?", "Удалить", "Отмена"))
            {
                App.Database.DeleteItem(project.Id);
                await Navigation.PushAsync(new ProjectsPage());
            }
        }

        private async void SaveProject(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите изменить {project.Name}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.Name))
                {
                    App.Database.SaveItem(project);
                }
                await this.Navigation.PopAsync();
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}