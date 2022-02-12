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
        public EditProject(Project newProj)
        {
            InitializeComponent();
            project = newProj;

            txt_AddName.Text = project.Name;
            txt_AddDescription.Text = project.Description;
            txt_AddTel.Text = project.Phone;
            txt_AddEmail.Text = project.Email;
            txt_AddAdress.Text = project.Address;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void ButtonSave_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите изменить \n{project.Name}?", "Да", "Нет");

            if (result == true)
            {
                try
                {
                    var proj = (Project)BindingContext;
                    if (!String.IsNullOrEmpty(proj.Name))
                    {
                        App.Database.SaveItem(proj);
                    }
                    await this.Navigation.PopAsync();
                }
                catch (Exception)
                {
                    _ = DisplayAlert("Подтвердить действие", "Укажите имя", "Ок");
                }
            }
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите удалить \n{project.Name}?", "Да", "Нет");

            if (result == true)
            {
                App.database.DeleteItem(project.Id);
                ProjectsPage projectsPage = new ProjectsPage();
                await Navigation.PushAsync(projectsPage);
            }
        }
    }
}