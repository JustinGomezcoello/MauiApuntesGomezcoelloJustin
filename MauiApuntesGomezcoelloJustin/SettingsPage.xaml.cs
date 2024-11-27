namespace MauiApuntesGomezcoelloJustin.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            // Cargar la preferencia actual
            var useTabs = Preferences.Get("UseTabs", false);
            NavigationStylePicker.SelectedIndex = useTabs ? 1 : 0;
        }

        private void OnApplyButtonClicked(object sender, EventArgs e)
        {
            var selectedStyle = NavigationStylePicker.SelectedItem.ToString();
            var useTabs = selectedStyle == "Tabs";

            // Guardar la preferencia
            Preferences.Set("UseTabs", useTabs);

            // Reiniciar la navegación con la nueva configuración
            Application.Current.MainPage = new AppShell();
        }
    }
}
