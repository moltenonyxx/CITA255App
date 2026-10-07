using System.ComponentModel.Design;
using System.Diagnostics;

namespace CITA255Midterm;

public partial class OmeletteInfo : ContentPage
{
	public OmeletteInfo()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void omeletteCart(object sender, EventArgs e)
    {
        try 
        {
            string.IsNullOrWhiteSpace(omeletteAmount.Text);
            if (double.TryParse(omeletteAmount.Text, out double omeletteNumber) & omeletteNumber > 0)
            {
                omeletteResult.Text = $"Added {omeletteNumber} Omelette to cart";
            }
            else
            {
                DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
            }
        }  
        catch (ArgumentOutOfRangeException)
        {
            omeletteResult.Text = "That does not exist";
        }
        catch (FormatException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a number", "OK");
        }
        catch (ArgumentNullException)
        {
            omeletteResult.Text = "Please enter a number here";
        }
        catch (OverflowException)
        {
            DisplayAlertAsync("Invalid Input", "Please enter a shorter number", "OK");
        }

    }
}