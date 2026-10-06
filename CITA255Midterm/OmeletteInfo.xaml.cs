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
}