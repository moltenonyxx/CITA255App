using System.Xml.Serialization;

namespace temp_255
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private async void OnBackClicked (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("MainPage");
        }
    }
}
