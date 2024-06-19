using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Vista;
using VistaModelo6A.VistaModelo;
using Xamarin.Forms;

namespace ViewModel.VistaModelo
{
    public class VistaModeloPagina1 : BaseVistaModelo
    {
        #region Atributos
        string _N1;
        string _N2;
        string _R;
        string _Mensaje;
        DateTime _fecha;
        string _resultadoFecha;
        string _tipoUsuario;
        #endregion

        #region Constructor
        public VistaModeloPagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha = DateTime.Now;
        }
        #endregion

        #region Objetos
        public string Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }

        public string TipoUsuario
        {
            get { return _tipoUsuario; }
            set { SetValue(ref _tipoUsuario, value); }
        }
        public string seleccionarTipoUsuario
        {
            get { return _tipoUsuario; }
            set { SetValue(ref _tipoUsuario, value);
                TipoUsuario = _tipoUsuario;
            }
        }
    
        public string ResultadoFecha
        {
            get { return _resultadoFecha; }
            set { SetValue(ref _resultadoFecha, value);  }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { 
                SetValue(ref _fecha, value);
                ResultadoFecha = _fecha.ToString("dd/MMM/yyyy");
        
            }
        }

        #endregion

        #region Procesos 

        public async Task NavegarPagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }
        public async Task NavegarCalcularIMC()
        {
            await Navigation.PushAsync(new CalcularIMC());
        }
        public async Task ProcesoAsyncrono()
        {
            
        }
        
        public void ProcesoSimple()
        {

        }
        //El proceso de la alerta
        public async Task ProcesoAsynAlerta()
        {
            await DisplayAlert("Titulo", "Mensaje", "OK");
        }
        //el proceso de la suma
        public async Task Sumar()
        {
            double n1 = 0, n2 = 0, respuesta = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            respuesta = n1 + n2;
            R = respuesta.ToString();
        }

        #endregion

        #region Comandos

        public ICommand ProcesoAsynCommand => new Command(async () => ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand ProcesoAlertCommand => new Command(async() => await ProcesoAsynAlerta());
        public ICommand ProcesoSumarCommand => new Command(async () => await Sumar());
        public ICommand ProcesoAsynNavegarPagina2Command => new Command(async () => await NavegarPagina2());
        public ICommand ProcesoAsynNavegarCalcularIMCCommand => new Command(async () => await NavegarCalcularIMC());


        #endregion
    }
}

