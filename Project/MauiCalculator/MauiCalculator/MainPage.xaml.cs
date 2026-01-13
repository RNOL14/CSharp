
namespace MauiCalculator;

public partial class MainPage : ContentPage
{
	public string CurrentInput { get; set; } = string.Empty;
	public string RunningTotal { get; set; } = string.Empty;

	private string selectedOperator;
	string[] operators = { "+", "-", "*", "/" };
	string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };

	bool resetOnNextInput = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var btn = sender as Button;
		var thisInput = btn.Text;

		// NUMBER
		if (numbers.Contains(thisInput))
		{
			if (resetOnNextInput)
			{
				CurrentInput = string.Empty;
				resetOnNextInput = false;
			}

			CurrentInput += thisInput;
			LCD.Text = CurrentInput;
		}

		// OPERATOR
		else if (operators.Contains(thisInput))
		{
			if (!string.IsNullOrEmpty(CurrentInput))
			{
				if (!string.IsNullOrEmpty(RunningTotal))
				{
					var result = PerformCalculation();
					RunningTotal = result.ToString();
				}
				else
				{
					RunningTotal = CurrentInput;
				}

				selectedOperator = thisInput;
				CurrentInput = string.Empty;
			}
		}

		// EQUALS
		else if (thisInput == "=")
		{
			var result = PerformCalculation();
			LCD.Text = result.ToString();

			CurrentInput = result.ToString();
			RunningTotal = string.Empty;
			resetOnNextInput = true;
		}
	}

	private double PerformCalculation()
	{
		double currentVal;
		double.TryParse(CurrentInput, out currentVal);

		double runningVal;
		double.TryParse(RunningTotal, out runningVal);

		double result = 0;

		switch (selectedOperator)
		{
			case "+":
				result = runningVal + currentVal;
				break;
			case "-":
				result = runningVal - currentVal;
				break;
			case "*":
				result = runningVal * currentVal;
				break;
			case "/":
				result = currentVal != 0 ? runningVal / currentVal : 0;
				break;
			default:
				result = currentVal;
				break;
		}

		return result;
	}
}