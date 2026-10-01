using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CITA255Ex
{
    public partial class MainPage : ContentPage
    {
        double totalGames = 0.0;
        double totalTime = 0.0;
        
        List<string> games = new List<string>
        {
            "Marvel Rivals", "Valheim", "Monster Hunter", "Schedule 1", "Minecraft", "Mortal Kombat", "Darktide", "Slay the Spire 2", "BTD6", "Pokemon"
        };


        List<double> time = new List<double>
        {
            2.5, 4.0, 3.0, 4.5, 2.75, 1.5, 2, 1.25, 1, 3.25
        };

        public MainPage()
        {
            InitializeComponent();
            gamesList.ItemsSource = games;
            timeList.ItemsSource = time;
            foreach (string gamesList in games)
            {
                Debug.WriteLine(gamesList);
            }
        }
        private void onTotalClicked(object sender, EventArgs e)
        {
            foreach (double timeElement in time)
            {
                totalTime = time.Sum();
                timeTotal.Text = $"Total: {totalTime:N2}";
            }


        }

    }   
        

    }
