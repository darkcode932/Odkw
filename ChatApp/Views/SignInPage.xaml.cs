namespace ChatApp.Views;
using ChatApp.ViewModels;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        BindingContext = new SignInViewModel(Navigation);
    }

    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }

    private async void SignIn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HomeView));
    }
}