namespace CITA255Midterm;

public partial class PancakesInfo : ContentPage
{
	public PancakesInfo()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void pancakeCart(object sender, EventArgs e)
    {
        try
        {
            string.IsNullOrWhiteSpace(pancakeAmount.Text);
            if (double.TryParse(pancakeAmount.Text, out double pancakeNumber) & pancakeNumber > 0)
            {
                pancakeResult.Text = $"Added {pancakeNumber} Pancake(s) to cart";
            }
            else
            {
                DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            pancakeResult.Text = "That does not exist";
        }
        catch (FormatException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
        }
        catch (ArgumentNullException)
        {
            pancakeResult.Text = "Please enter a number here";
        }
        catch (OverflowException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a shorter number", "OK");
        }
    }
}