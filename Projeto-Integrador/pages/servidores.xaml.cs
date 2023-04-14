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
    }
}
