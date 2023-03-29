using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Projeto_Integrador.pages.shell;
namespace Projeto_Integrador.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class shellscript : ContentPage
{
    public shellscript()
    {
        InitializeComponent();
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.shell.comandosbasicos();
            Navigation.PushModalAsync(x);
        }
    }
}