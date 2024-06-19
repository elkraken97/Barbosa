using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using VistaModelo6A.VistaModelo;
namespace ViewModel.VistaModelo
{
    public class VistaModeloCalcularIMC : BaseVistaModelo
    {
        #region Atributos
        string _Texto, _resultado;
        double _altura, _peso;
        #endregion

        #region Constructor
        public VistaModeloCalcularIMC(INavigation navigation)
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
        public double Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }

        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
      
            set { SetValue(ref _resultado, value); }
        }

        #endregion

        #region Procesos 


        public void CalcularIMC()
        {
            double peso = 0, altura = 0, res = 0;
            peso = Convert.ToDouble(Peso);
            altura = Convert.ToDouble(Altura);
   
            
             res = peso/ (altura * altura);
        

            if (res < 18.5)
            {
                DisplayAlert("IMC", "Tienes bajo peso", "OK");
            }
            else if(res >= 18.5 && res <= 24.9)
            {
                DisplayAlert("IMC", "Estas en tu peso", "OK");
            }
            else if (res >= 25 && res <= 29.9)
            {
                DisplayAlert("IMC", "Tienes sobrepeso", "OK");
            }
            else
            {
                DisplayAlert("IMC", "Tienes obesidad", "OK");
            }
            Resultado = res.ToString();
        }
        public async Task ProcesoAsyncrono()
        {

        }
        
        public void ProcesoSimple()
        {

        }
        #endregion

        #region Comandos
        public ICommand ProcesoAsynCommand => new Command(async () => ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
  
        public ICommand ProcesoIMCommand => new Command(CalcularIMC);
        #endregion
    }
}

