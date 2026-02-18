
namespace MauiApp13.Controls;

public partial class MildredStepper : ContentView
{
  // Bindable property for Value
  public static readonly BindableProperty ValueProperty =
      BindableProperty.Create(
          nameof(Value),
          typeof(int),
          typeof(MildredStepper),
          0,
          BindingMode.TwoWay);

  public int Value
  {
    get => (int)GetValue(ValueProperty);
    set => SetValue(ValueProperty, value);
  }

  // Bindable property for IsEnabled (NEW keyword like the book)
  public static new readonly BindableProperty IsEnabledProperty =
      BindableProperty.Create(
          nameof(IsEnabled),
          typeof(bool),
          typeof(MildredStepper),
          true,
          propertyChanged: OnIsEnabledChanged);

  public new bool IsEnabled
  {
    get => (bool)GetValue(IsEnabledProperty);
    set => SetValue(IsEnabledProperty, value);
  }

  public MildredStepper()
  {
    InitializeComponent();
    ValueEntry.Text = "0";
  }

  private void MinusButton_Clicked(object sender, EventArgs e)
  {
    if (Value > 0)
    {
      Value--;
      ValueEntry.Text = Value.ToString();
    }
  }

  private void PlusButton_Clicked(object sender, EventArgs e)
  {
    Value++;
    ValueEntry.Text = Value.ToString();
  }

  private void ValueEntry_TextChanged(object sender, TextChangedEventArgs e)
  {
    if (string.IsNullOrWhiteSpace(e.NewTextValue))
      return;

    // prevent negative
    if (e.NewTextValue.StartsWith("-"))
    {
      ValueEntry.Text = Value.ToString();
      return;
    }

    if (int.TryParse(e.NewTextValue, out int value))
    {
      Value = value;
    }
  }

  private static void OnIsEnabledChanged(BindableObject bindable, object oldValue, object newValue)
  {
    if (bindable is MildredStepper mildredStepper)
    {
      bool enabled = (bool)newValue;

      mildredStepper.ValueEntry.IsEnabled = enabled;
      mildredStepper.PlusButton.IsEnabled = enabled;
      mildredStepper.MinusButton.IsEnabled = enabled;
    }
  }
}
