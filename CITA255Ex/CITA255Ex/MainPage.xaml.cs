using System.Diagnostics;

namespace CITA255Ex
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            List<string> games = new List<string>
            {
                "Marvel Rivals", "Valheim", "Monster Hunter", "Schedule 1", "Minecraft", "Mortal Kombat", "Darktide", "Slay the Spire 2", "BTD6", "Pokemon"
            };

            foreach (string gamesList in games)
            {
                Debug.WriteLine(gamesList);
            }
            List<Double> time = new List<double>
            {
                2, 4, 3, 4, 2, 1, 2, 1, 1, 3
            };
            InitializeComponent();
            gamesList.ItemsSource = games;
            timeList.ItemsSource = time;
            
        }


    }
}
