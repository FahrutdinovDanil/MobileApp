using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private async void Button_Registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void Button_Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}