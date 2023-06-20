using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto_Integrador.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class sobre : ContentPage
	{
		public sobre ()
		{
			InitializeComponent ();
            this.BindingContext = new MainPageViewModel();
        }
    }
}