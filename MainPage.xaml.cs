using MauiDemoApp.Platforms.Android;
using MauiDemoApp.Platforms.Android.Page;

namespace MauiDemoApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            if (!AppState.IsLoggedIn)
            {
                Navigation.PushModalAsync(new LoginPage());
            }
        }

        

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
