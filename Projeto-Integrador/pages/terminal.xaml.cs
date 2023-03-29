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
public partial class terminal : ContentPage
{
    public terminal()
    {
        InitializeComponent();
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var controlAcess = new Projeto_Integrador.pages.acesso();
            Navigation.PushModalAsync(controlAcess);
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            var controlGest = new Projeto_Integrador.pages.gestao();
            Navigation.PushModalAsync(controlGest);
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            var controlManut = new Projeto_Integrador.pages.manut();
            Navigation.PushModalAsync(controlManut);
        }
    }
}