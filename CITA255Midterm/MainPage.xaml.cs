namespace CITA255Midterm
{
    public partial class MainPage : ContentPage
    {
        List<string> breakfast =
        [
        "Pancakes",
        "Waffles",
        "French Toast",
        "Omelette"
        ];

        public MainPage()
        {
            InitializeComponent();
            breakfastList.ItemsSource = breakfast;

        }

        private async void onMenuSelected(object sender, SelectionChangedEventArgs e)
        {
            if(e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                breakfastList.SelectedItem = null;

                if(picked == "Pancakes")
                {
                    await Shell.Current.GoToAsync("pancakes");
                } 
                else if (picked == "Waffles")
                {
                    await Shell.Current.GoToAsync("waffles");
                }
                else if (picked == "French Toast")
                {
                    await Shell.Current.GoToAsync("frenchtoast");
                }
                else if (picked == "Omelette")
                {
                    await Shell.Current.GoToAsync("omelette");
                }
                
            }
        }
    }
}
