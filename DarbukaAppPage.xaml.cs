
using AudioManager = Plugin.Maui.Audio.AudioManager;

namespace MauiDarbuka;

public partial class DarbukaAppPage : ContentPage
{


    public DarbukaAppPage()
	{
		InitializeComponent();

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		Button button = (Button)sender;
        await ImgDarbuka.ScaleTo(0.8, 50, Easing.Linear);
        await ImgDarbuka.ScaleTo(1, 50, Easing.Linear);

        PlaySound(button.CommandParameter.ToString());

    }

    private async Task PlaySound(string sound)
    {
        
        var player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(sound + ".mp3"));
        player.Play();
    }
}