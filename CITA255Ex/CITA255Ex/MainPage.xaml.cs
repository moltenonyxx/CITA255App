using System.Diagnostics;

namespace CITA255Ex
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            List<string> snacks = new List<string>
            {
                "Apples", "Oranges", "Lemon"
            };

            foreach (string snack in snacks)
            {
                Debug.WriteLine(snack);
            }
            InitializeComponent();
            snackList.ItemsSource = snacks;
            
        }


    }
}
