using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.ViewModels
{
    internal class SignUpViewModel

    {
        public string webApiKey = "AIzaSyCjQC72xl8G-Vrs0B6hi-V4rYK7Flc1GUo";
        private INavigation _navigation;
        public Command SignUpUser { get; }

        public SignUpViewModel(INavigation navigation)
        {
            this._navigation = navigation;

            SignUpUser = new Command(SignUpUserTappedAsync);
        }

        private async void SignUpUserTappedAsync(object obj)
        {
            try 
            {
                //var authProvider = new FirebaseAuthProvider();
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}
