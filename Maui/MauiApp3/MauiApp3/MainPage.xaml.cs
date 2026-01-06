namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert(
                "Error",
                "Please enter username and password",
                "OK"
            );
        }
        else
        {
            await DisplayAlert(
                "Success",
                $"Welcome {username}",
                "OK"
            );
        }
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        usernameEntry.Text = string.Empty;
        passwordEntry.Text = string.Empty;
    }
}