using Plugin.Maui.Audio;

namespace Copilot1
{
    public partial class MainPage : ContentPage
    {
        IAudioPlayer cat, dog, duck, sheep, cow, owl;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImage1Clicked(object sender, EventArgs e)
        {
            if (cat == null)
                cat = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("cat.mp3").Result);

            cat.Play();
        }
        private void OnImage2Clicked(object sender, EventArgs e)
        {
            if (dog == null)
                dog = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("dog.mp3").Result);

            dog.Play();
        }
        private void OnImage3Clicked(object sender, EventArgs e)
        {
            if (duck == null)
                duck = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("duck.mp3").Result);

            duck.Play();
        }
        private void OnImage4Clicked(object sender, EventArgs e)
        {
            if (sheep == null)
                sheep = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("sheep.mp3").Result);

            sheep.Play();
        }
        private void OnImage5Clicked(object sender, EventArgs e)
        {
            if (cow == null)
                cow = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("cow.mp3").Result);

            cow.Play();
        }
        private void OnImage6Clicked(object sender, EventArgs e)
        {
            if (owl == null)
                owl = AudioManager.Current.CreatePlayer(FileSystem.OpenAppPackageFileAsync("owl.mp3").Result);

            owl.Play();
        }
    }

}
