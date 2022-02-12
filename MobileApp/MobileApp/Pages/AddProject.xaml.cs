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
    public partial class AddProject : ContentPage
    {
        public AddProject()
        {
            InitializeComponent();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            var proj = (Project)BindingContext;
            if (!String.IsNullOrEmpty(proj.Name))
            {
                App.Database.SaveItem(proj);
            }
            this.Navigation.PopAsync();
        }
    }
}