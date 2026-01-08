namespace MauiApp5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


	private async void OnSaveClicked(object sender, EventArgs e)
	{
		string name = NameEntry.Text ?? "User";
		bool notifications = NotifySwitch.IsToggled;

		string gender =
				MaleRadio.IsChecked ? "Male" :
				FemaleRadio.IsChecked ? "Female" :
				OtherRadio.IsChecked ? "Other" : "Not selected";

		string language = LanguagePicker.SelectedItem?.ToString() ?? "Not selected";

		await DisplayAlert(
				"Saved",
				$"Name: {name}\nGender: {gender}\nLanguage: {language}\nNotifications: {notifications}",
				"OK"
		);
	}
}
