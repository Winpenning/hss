
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace Projeto_Integrador
{
    public class MainPageViewModel
    {
        public ICommand ClickCommand => new Command<string>((url) =>
        {
           // Device.OpenUri(new System.Uri(url));
           // Device.OpenUri está obsoleto
            Launcher.OpenAsync(new System.Uri(url));
        });
    }
}