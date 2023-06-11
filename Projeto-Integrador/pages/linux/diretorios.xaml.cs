using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto_Integrador.pages.linux
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class diretorios : ContentPage
{
    public diretorios()
    {
        InitializeComponent();
    }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Tipos de Exclusão","rm 'arquivo' - para excluir um arquivo.\nrm - rf 'diretório' para excluir um diretório.","FECHAR");
        }
    }
}