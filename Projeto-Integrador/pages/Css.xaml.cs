using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto_Integrador.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Css : ContentPage
{
    public Css()
    {
        InitializeComponent();
    }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.css.dhcp();
            Navigation.PushModalAsync(x);
        }

        private void buttonComandosWin(object sender, EventArgs e)
        {
            var y = new Projeto_Integrador.pages.css.comandosWin();
            Navigation.PushModalAsync(y);
        }
    }
}