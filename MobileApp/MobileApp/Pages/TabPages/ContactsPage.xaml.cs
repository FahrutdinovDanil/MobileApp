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
    public partial class ContactsPage : ContentPage
    {
        Project project;
        public ContactsPage(Project newProj)
        {
            InitializeComponent();

            project = newProj;

            txt_ContAdress.Text = project.Address;
            txt_ContEmail.Text = project.Email;
            txt_contc_tel.Text = project.Phone;
        }
        public ContactsPage()
        {
            InitializeComponent();
        }
    }
}