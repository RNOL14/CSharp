namespace MauiCollections;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();

		// ProductsView.ItemsSource = new List<Product>
		// 		{
		// 				new Product { Name = "Phone", Price = 19999 },
		// 				new Product { Name = "Laptop", Price = 59999 },
		// 				new Product { Name = "Headphones", Price = 2999 }
		// 		};


		ProductsList.ItemsSource = new List<Product>
				{
						new Product { Name = "Phone", Price = 19999 },
						new Product { Name = "Laptop", Price = 59999 },
						new Product { Name = "Headphones", Price = 2999 }
				};
	}


}
