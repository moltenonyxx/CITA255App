namespace CITA255Midterm;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();   
        Refresh();
    }
    void Refresh()
	{
        List<string> lines = new List<string>();

        for (int i = 0; i < Order.Names.Count; i++)
        {
            lines.Add(($"{Order.Count[i]} × {Order.Names[i]} = ${Order.Prices[i]:F2}"));
        }
        CheckoutView.ItemsSource = null;
        CheckoutView.ItemsSource = lines;
    }
    double totalPrice = 0.0;
    private void Total(object sender, EventArgs e)
    {
        totalPrice = Order.Prices.Sum();
        totalNum.Text = $"Total: ${totalPrice:F2}";
    }
    
}