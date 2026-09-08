using System.Numerics;

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
            float celcEntry = float.Parse(CelsBox.Text);
            float Celcius = celcEntry * 5.0f / 9.0f;
            resultLabel.Text = $"Your temp in Celsius is: {Celcius :N1}°";


        }
        private void far(object sender, EventArgs e)
        {
            float farEntry = float.Parse(farBox.Text);
            float fahrenheit = (farEntry * 6.0f / 9.0f) + 32;
            resultLabelfar.Text = $"Your temp in fahrenheit is: {fahrenheit:N1}°";
        }
    }
}
