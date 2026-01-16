using System.Collections.ObjectModel;

namespace OutlookClone;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Simpson> Simpsons { get; set; } = new();

	public MainPage()
	{
		InitializeComponent();

		// Static dummy data (NO API)
		Simpsons.Add(new Simpson
		{
			character = "Homer Simpson",
			quote = "D'oh! Why you little!",
			image = "https://i.imgur.com/8RKXAIV.png"
		});

		Simpsons.Add(new Simpson
		{
			character = "Marge Simpson",
			quote = "I just think they're neat.",
			image = "https://i.imgur.com/1bX5QH6.png"
		});

		Simpsons.Add(new Simpson
		{
			character = "Bart Simpson",
			quote = "Eat my shorts!",
			image = "https://i.imgur.com/UePbdph.png"
		});

		Simpsons.Add(new Simpson
		{
			character = "Lisa Simpson",
			quote = "If anyone wants me, I'll be in my room.",
			image = "https://i.imgur.com/Qp0FJzG.png"
		});

		Simpsons.Add(new Simpson
		{
			character = "Moe Szyslak",
			quote = "I was saying Boo-urns.",
			image = "https://i.imgur.com/4AiXzf8.png"
		});

		MessageCollection.ItemsSource = Simpsons;

		// Hide loader (not needed for static data)
		LoadingIndicator.IsVisible = false;
	}
}
