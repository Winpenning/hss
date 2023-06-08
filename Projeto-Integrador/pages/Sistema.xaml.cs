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
	public partial class Sistema : ContentPage
	{
		public Sistema ()
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

        private void botao_usuario(object sender, EventArgs e)
        {
            var usuario = new Projeto_Integrador.pages.linux.usuario();
            Navigation.PushModalAsync(usuario);
        }

        private void botao_diretorios(object sender, EventArgs e)
        {
            var diretorios = new Projeto_Integrador.pages.linux.diretorios();
            Navigation.PushModalAsync(diretorios);
        }
        private void botao_terminaleSistema(object sender, EventArgs e)
        {
            var terminaleSistema = new Projeto_Integrador.pages.linux.terminaleSistema();
            Navigation.PushModalAsync(terminaleSistema);
        }
    }
}