using MauiCarousel.Models;
namespace MauiCarousel;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		var products = new List<Product>
				{
						new Product
						{
								Title = "Phone",
								Price = 19999,
								Image = "phone.png"
						},
						new Product
						{
								Title = "Laptop",
								Price = 59999,
								Image = "laptop.png"
						},
						new Product
						{
								Title = "Headphones",
								Price = 2999,
								Image = "headphones.png"
						}
				};

		ProductCarousel.ItemsSource = products;
		ProductIndicator.ItemsSource = products;

		// 🔗 Connect IndicatorView with CarouselView
		ProductCarousel.IndicatorView = ProductIndicator;
	}
}
