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

        //Windows
        private void buttonDhcpWin(object sender, EventArgs e)
        {
            var VarDhcpWin = new Projeto_Integrador.pages.css.dhcpWin();
            Navigation.PushModalAsync(VarDhcpWin);
        }

        private void buttonComandosWin(object sender, EventArgs e)
        {
            var VarComandosWin = new Projeto_Integrador.pages.css.comandosWin();
            Navigation.PushModalAsync(VarComandosWin);
        }

        private void buttonMaquinaWin(object sender, EventArgs e)
        {
            var VarMaquinaWin = new Projeto_Integrador.pages.css.maquinaWin();
            Navigation.PushModalAsync(VarMaquinaWin);
        }

        private void buttonShellWin(object sender, EventArgs e)
        {
            var VarShellWin = new Projeto_Integrador.pages.css.shellWin();
            Navigation.PushModalAsync(VarShellWin);
        }

        private void buttonDnsWin(object sender, EventArgs e)
        {
            var VarDnsWin = new Projeto_Integrador.pages.css.dnsWin();
            Navigation.PushModalAsync(VarDnsWin);
        }

        private void buttonIisWin(object sender, EventArgs e)
        {
            var VarIisWin = new Projeto_Integrador.pages.css.iisWin();
            Navigation.PushModalAsync(VarIisWin);
        }

        private void buttonAddsWin(object sender, EventArgs e)
        {
            var VarAddsWin = new Projeto_Integrador.pages.css.addsWin();
            Navigation.PushModalAsync(VarAddsWin);
        }

        //Linux

        private void buttonTerminalLin(object sender, EventArgs e)
        {
            var VarTerminalLin = new Projeto_Integrador.pages.css.terminalLin();
            Navigation.PushModalAsync(VarTerminalLin);
        }

        private void buttonMaquinaLin(object sender, EventArgs e)
        {
            var VarMaquinaLin = new Projeto_Integrador.pages.css.maquinaLin();
            Navigation.PushModalAsync(VarMaquinaLin);
        }

        private void buttonShellLin(object sender, EventArgs e)
        {
            var VarShellLin = new Projeto_Integrador.pages.css.shellLin();
            Navigation.PushModalAsync(VarShellLin);
        }

        private void buttonFtpLin(object sender, EventArgs e)
        {
            var VarFtpLin = new Projeto_Integrador.pages.css.ftpLin();
            Navigation.PushModalAsync(VarFtpLin);
        }

        private void buttonDhcpLin(object sender, EventArgs e)
        {
            var VarDhcpLin = new Projeto_Integrador.pages.css.dhcpLin();
            Navigation.PushModalAsync(VarDhcpLin);
        }

        private void buttonHttpLin(object sender, EventArgs e)
        {
            var VarHttpLin = new Projeto_Integrador.pages.css.httpLin();
            Navigation.PushModalAsync(VarHttpLin);
        }
    }
}