using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ViewModel.VistaModelo;

namespace ViewModel.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalcularIMC : ContentPage
	{
		public CalcularIMC ()
		{
			InitializeComponent ();
            BindingContext = new VistaModeloCalcularIMC(Navigation);
        }
	}
}