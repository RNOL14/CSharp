
namespace StepperCustom.Pages;

public partial class InputPage : ContentPage
{
  public InputPage()
  {
    InitializeComponent();
    BindingContext = new InputViewModel();
  }
}
