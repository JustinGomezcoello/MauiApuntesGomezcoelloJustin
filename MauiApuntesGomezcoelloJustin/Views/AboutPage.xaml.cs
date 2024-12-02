using MauiApuntesGomezcoelloJustin.Models;

namespace MauiApuntesGomezcoelloJustin.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        var about = new About
        {
            Icon = "meme.png"
        };

        BindingContext = about;
    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}