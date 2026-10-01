namespace CITA255Midterm
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("pancakes", typeof(PancakesInfo));

            Routing.RegisterRoute("waffles", typeof(WafflesInfo));

            Routing.RegisterRoute("frenchtoast", typeof(FrenchToastInfo));

            Routing.RegisterRoute("omelette", typeof(OmeletteInfo));
        }
    }
}
