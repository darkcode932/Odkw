using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatApp.Views;

namespace ChatApp.ViewModels
{
    internal class SignInViewModel
    {
        public string webApiKey = "AIzaSyCjQC72xl8G-Vrs0B6hi-V4rYK7Flc1GUo";
        public Command SignInBtn { get; } 
        public SignInViewModel(INavigation navigation)
        {
            this._navigation = navigation;
            SignInBtn = new Command(SignInBtnTappedAsync);
        }

        private async void SignInBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new HomeView());
        }

        private INavigation _navigation;
    }
}
