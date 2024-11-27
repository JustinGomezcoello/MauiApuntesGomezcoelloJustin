namespace MauiApuntesGomezcoelloJustin
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            ConfigureNavigation();

            Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
        }
        private void ConfigureNavigation()
        {
            var useTabs = Preferences.Get("UseTabs", false);
            Items.Clear(); // Limpiar Shell antes de configurar

            if (useTabs)
            {
                // Configurar TabBar
                var tabBar = new TabBar
                {
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Notes",
                            ContentTemplate = new DataTemplate(typeof(Views.AllNotesPage)),
                            Icon = "icon_notes.png"
                        },
                        new ShellContent
                        {
                            Title = "About",
                            ContentTemplate = new DataTemplate(typeof(Views.AboutPage)),
                            Icon = "icon_about.png"
                        },
                        new ShellContent
                        {
                            Title = "Settings",
                            ContentTemplate = new DataTemplate(typeof(Views.SettingsPage)),
                            Icon = "icon_settings.png"
                        }
                    }
                };

                Items.Add(tabBar);
                FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilitar Flyout
            }
            else
            {
                // Configurar Flyout
                FlyoutBehavior = FlyoutBehavior.Flyout;

                Items.Add(new FlyoutItem
                {
                    Title = "Notes",
                    Icon = "icon_notes.png",
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Notes",
                            ContentTemplate = new DataTemplate(typeof(Views.AllNotesPage))
                        }
                    }
                });

                Items.Add(new FlyoutItem
                {
                    Title = "About",
                    Icon = "icon_about.png",
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "About",
                            ContentTemplate = new DataTemplate(typeof(Views.AboutPage))
                        }
                    }
                });

                Items.Add(new FlyoutItem
                {
                    Title = "Settings",
                    Icon = "icon_settings.png",
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Settings",
                            ContentTemplate = new DataTemplate(typeof(Views.SettingsPage))
                        }
                    }
                });
            }
        }
    }
}