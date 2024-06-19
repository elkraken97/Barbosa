using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VistaModelo6A.VistaModelo;
using Xamarin.Forms;
namespace ViewModel.VistaModelo
{
    public class VistaModeloPatron : BaseVistaModelo
    {
        #region Atributos
        string _Texto;
        #endregion

        #region Constructor
        public VistaModeloPatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        #endregion

        #region Procesos 
        public async Task ProcesoAsyncrono()
        {

        }
        #endregion
        public void ProcesoSimple()
        {

        }


        #region Comandos
        public ICommand ProcesoAsynCommand => new Command(async() => ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}