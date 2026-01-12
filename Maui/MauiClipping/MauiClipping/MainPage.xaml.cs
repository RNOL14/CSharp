using MauiClipping.Models;
using System.Collections.ObjectModel;
namespace MauiClipping;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Product> Products { get; set; }

	public MainPage()
	{

		InitializeComponent();
		Products = new ObservableCollection<Product>
				{
						new Product
						{
								Title = "Gigaphone XT12",
								Description = "The little brother. Has all the same hardware as the flagship.",
								Price = 1099,
								Image = "phone1.jpg"
						},
						new Product
						{
								Title = "Gigaphone AF10",
								Description = "This budget friendly model won’t break the bank.",
								Price = 999,
								Image = "phone2.jpg"
						},
						new Product
						{
								Title = "Gigaphone AF05",
								Description = "Our entry level Gigaphone. It looks cool but doesn’t make calls.",
								Price = 699,
								Image = "phone3.jpg"
						}
				};

		BindingContext = this;
	}

}
