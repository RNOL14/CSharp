using MauiTodoextended.Models;
using System.Collections.ObjectModel;

namespace MauiTodoextended
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<TodoItem> Todos { get; set; }

		public MainPage()
		{
			InitializeComponent();

			Todos = new ObservableCollection<TodoItem>();
			BindingContext = this;
		}

		private void OnAddClicked(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TitleEntry.Text))
				return;

			Todos.Add(new TodoItem
			{
				Title = TitleEntry.Text,
				Due = DueDatePicker.Date
			});

			TitleEntry.Text = string.Empty;
		}

		private async void SwipeItem_Invoked(object sender, EventArgs e)
		{
			var item = sender as SwipeItem;

			await DisplayAlert(
					item.Text,
					$"You invoked the {item.Text} action.",
					"OK");
		}
	}
}