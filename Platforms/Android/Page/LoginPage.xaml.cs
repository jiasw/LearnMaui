namespace MauiDemoApp.Platforms.Android.Page;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		AppState.IsLoggedIn = true;
		await Navigation.PopModalAsync();
    }
}