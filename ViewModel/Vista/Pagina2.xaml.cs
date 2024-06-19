using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewModel.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
			BindingContext = new VistaModeloPagina2(Navigation);
		}
	}
}