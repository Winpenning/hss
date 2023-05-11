using Projeto_Integrador.pages.css;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto_Integrador.pages
{
    public partial class servidores : ContentPage
    {
        public servidores()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.css.dhcp();
            Navigation.PushModalAsync(x);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.css.ftp();
            Navigation.PushModalAsync(x);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.css.apachehttp();
            Navigation.PushModalAsync(x);
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var x = new Projeto_Integrador.pages.css.samba();
            Navigation.PushModalAsync(x);
        }
    }
}
