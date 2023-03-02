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
    public partial class Redes : ContentPage
    {
        public Redes()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.rede.modeloosi();
            Navigation.PushModalAsync(x);
        }
    }

    
}