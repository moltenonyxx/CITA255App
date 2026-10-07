namespace CITA255Midterm;

public partial class WafflesInfo : ContentPage
{
	public WafflesInfo()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void wafflesCart(object sender, EventArgs e)
    {
        try
        {
            string.IsNullOrWhiteSpace(wafflesAmount.Text);
            if (double.TryParse(wafflesAmount.Text, out double wafflesNumber) & wafflesNumber > 0)
            {
                wafflesResult.Text = $"Added {wafflesNumber} French Toast to cart";
            }
            else
            {
                DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            wafflesResult.Text = "That does not exist";
        }
        catch (FormatException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
        }
        catch (ArgumentNullException)
        {
            wafflesResult.Text = "Please enter a number here";
        }
        catch (OverflowException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a shorter number", "OK");
        }
    }
}