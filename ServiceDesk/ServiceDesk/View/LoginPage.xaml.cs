using ServiceDesk.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServiceDesk.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SingInProcedure(Object sender, EventArgs e)
        {
            User user = new User(entryUsername.Text, entryPassword.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "login Sucess", "Oke");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Oke");
            }
        }
    }
}