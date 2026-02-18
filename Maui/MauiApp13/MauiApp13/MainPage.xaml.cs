using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace MauiApp13;

public partial class MainPage : ContentPage
{
	private int _count;
	private bool _isStepperEnabled = true;

	public int Count
	{
		get => _count;
		set
		{
			_count = value;
			OnPropertyChanged();
		}
	}

	public bool IsStepperEnabled
	{
		get => _isStepperEnabled;
		set
		{
			_isStepperEnabled = value;
			OnPropertyChanged();
		}
	}

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	private void OnToggleClicked(object sender, EventArgs e)
	{
		IsStepperEnabled = !IsStepperEnabled;
	}

	public new event PropertyChangedEventHandler? PropertyChanged;

	protected new void OnPropertyChanged([CallerMemberName] string? name = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
