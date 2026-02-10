namespace StepperCustom.Controls;

public partial class MildredStepper : ContentView
{
  // ✅ Bindable Property for Value
  public static readonly BindableProperty ValueProperty =
      BindableProperty.Create(
          nameof(Value),
          typeof(int),
          typeof(MildredStepper),
          0,
          BindingMode.TwoWay,
          propertyChanged: OnValueChanged);

  public int Value
  {
    get => (int)GetValue(ValueProperty);
    set => SetValue(ValueProperty, value);
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

    // Prevent negative input
    if (e.NewTextValue.StartsWith("-"))
    {
      ValueEntry.Text = Value.ToString();
      return;
    }

    if (int.TryParse(e.NewTextValue, out var value))
    {
      Value = value;
    }
    else
    {
      ValueEntry.Text = Value.ToString();
    }
  }

  private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
  {
    if (bindable is MildredStepper mildredStepper)
    {
      mildredStepper.ValueEntry.Text = newValue.ToString();
    }
  }
}
