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

        private void botao_terminal(object sender, EventArgs e)
        {
            var terminalLin = new Projeto_Integrador.pages.terminal();
            Navigation.PushModalAsync(terminalLin);
        }

        private void botao_power(object sender, EventArgs e)
        {
            var powershell = new Projeto_Integrador.pages.powershell();
            Navigation.PushModalAsync(powershell);
        }

        private void botao_shellscript(object sender, EventArgs e)
        {
            var shellscript = new Projeto_Integrador.pages.shellscript();
            Navigation.PushModalAsync(shellscript);
        }

        private void botao_rede(object sender, EventArgs e)
        {
            var rede = new Projeto_Integrador.pages.linux.rede();
            Navigation.PushModalAsync(rede);
        }
    }
}