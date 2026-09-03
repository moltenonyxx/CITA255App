namespace CITA255App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            string entrytext = compBox.Text;
            nameText.Text = $"Is your complaint:{entrytext}?";
           
        }

        private void cels(object sender, EventArgs e)
        {
            float celsEntry = float.Parse(CelsBox.Text);
            float Celsius = celsEntry * 5.0f / 9.0f;
            resultLabel.Text = $"Your temp in Celsius is:{celsEntry} °";


        }
    }
}
