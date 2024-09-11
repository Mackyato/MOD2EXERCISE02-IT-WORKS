using Microsoft.Maui.Controls;
using System;
using Module0Exercise0.View;
using Module0Exercise0.Services;

namespace Module0Exercise0.View
{
    public partial class LoginPage : ContentPage
    {
        private readonly IMyService _myService;
        public LoginPage(IMyService myService)
        {
            InitializeComponent();
            _myService = myService;

            var message = _myService.GetMessage();
            MyLabel.Text = message;
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Simple validation (this can be replaced with actual authentication logic)
            if (username == "admin" && password == "admin")
            {
                // Navigate to EmployeePage
                await Navigation.PushAsync(new EmployeePage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Incorrect username or password.", "OK");
            }
        }
    }
}
