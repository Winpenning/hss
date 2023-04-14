using System;
using Projeto_Integrador.pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto_Integrador
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            TabbedPage tb = new TabbedPage();
            tb.Children.Add(new MainPage());
            tb.Children.Add(new servidores());
            tb.Children.Add(new Css());
            MainPage = tb;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
