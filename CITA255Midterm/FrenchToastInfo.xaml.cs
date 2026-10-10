namespace CITA255Midterm;

public partial class FrenchToastInfo : ContentPage
{
	public FrenchToastInfo()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    float toastPrice = 0;
    double toastCost = 6.0;
    string toastName = string.Empty;

    private void toastCart(object sender, EventArgs e)
    {
        try
        {
            string.IsNullOrWhiteSpace(toastAmount.Text);
            if (double.TryParse(toastAmount.Text, out double toastNumber) & toastNumber > 0)
            {
                toastResult.Text = $"Added {toastNumber} French Toast to cart";
            }
            else
            {
                DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
            }
            double toastPrice = toastNumber * toastCost;
            Order.Count.Add(toastNumber);
            Order.Prices.Add(toastPrice);
            toastName = "French Toast";
            Order.Names.Add(toastName);
        }
        catch (ArgumentOutOfRangeException)
        {
            toastResult.Text = "That does not exist";
        }
        catch (FormatException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
        }
        catch (ArgumentNullException)
        {
            toastResult.Text = "Please enter a number here";
        }
        catch (OverflowException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a shorter number", "OK");
        }
        
    }
}