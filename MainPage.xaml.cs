namespace App3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnMostrarDatosClicked(object? sender, EventArgs e)
        {
            // Carrera

            string carrera = "";
            if(RadBtnInformatica.IsChecked)
                carrera = "Informatica";
            if (RadBtnContabilidad.IsChecked)
                carrera = "Contabilidad";
            if (RadBtnCiberseguridad.IsChecked)
                carrera = "Ciberseguridad";


            // Actividades

            string act = "";

            if (chkVideojuegos.IsChecked)
                act += "Videojuegos";
            if (chkDeportes.IsChecked)
                act += "Deportes";
            if (chkMusica.IsChecked)
                act += "Musica";

            // Semestre

            string sem = SemestrePck.SelectedItem?.ToString() ?? "No ha seleccionado un semestre";

            // Notificaciones

            string notificaciones = NotificationsSwitch.IsToggled?"Si":"No";

            // Resultado

            ResultLabel.Text =
                $"Nombre: {NameEntry.Text}\n" +
                $"Carrera: {carrera}\n" +
                $"Actividades {act}\n" +
                $"Semestre {sem}\n" +
                $"Notificaciones {notificaciones}\n";

        }
    }
}
