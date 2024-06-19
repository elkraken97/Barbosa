using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel.Modelo;
using VistaModelo6A.VistaModelo;
using Xamarin.Forms;

namespace ViewModel.VistaModelo
{
    public class VistaModeloPagina2: BaseVistaModelo
    {
        #region Atributos
        string _Texto;
       public  List<ModeloUsuarioscs> ListaUsuarios { set; get;  }
        #endregion

        #region Constructor
        public VistaModeloPagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostarUsuarios();
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
        public async Task ProcesoAsyncRegresarPagina1()
        {
            await Navigation.PopAsync();
        }
        #endregion
        public void ProcesoSimple()
        {

        }
        public void MostarUsuarios()
        {
            ListaUsuarios = new List<ModeloUsuarioscs>
            {
                new ModeloUsuarioscs
                {
                    Nombre = "Elyam",
                    Imagen="https://static.wikia.nocookie.net/brawlstars/images/6/63/Colette_Skin-Default.png"
                },
                new ModeloUsuarioscs
                {
                    Nombre="Nito",
                    Imagen="https://static.wikia.nocookie.net/brawlstars/images/a/a2/Crow_Skin-Default.png"
                },

                    new ModeloUsuarioscs
                {
                    Nombre="Piña",
                    Imagen="https://static.wikia.nocookie.net/brawlstars/images/5/52/Jacky_Skin-Default.png"
                }
            };
        }


        #region Comandos
        public ICommand ProcesoAsynRegresarPagina1Command => new Command(async () => ProcesoAsyncRegresarPagina1());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}

