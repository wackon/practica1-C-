using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Avion : Herencia
    {
        
        double ValMillas = 0;
        double ValTasaAer = 0;
        double ValTranspAero=0;

        public Avion(string destino, string nombre, double cedula, int diasViaje, int diasEsta, string tCamarote, string tHabitacion,string fechaViaje, double valorTransporte,
            int millas, double valMillas, double valTasaAer, double valTranspAero) : base(destino, nombre, cedula, diasEsta, tCamarote, tHabitacion, fechaViaje, valorTransporte,millas)

        {

            this.ValMillas = valMillas;
            this.ValTasaAer = valTasaAer;
            this.ValTranspAero = valTranspAero;

        }

        public Avion()
        {


        }

        #region GETTER AND SETTERS

        public double setValTasaAer(double valTasaAer)
        {
            return valTasaAer;
        }
        public double getValTasaAer()
        {
            return ValTasaAer;
        }


        public double gerValorTransporteAereo() { 
            return ValTranspAero;
        }
        public void setValTranspAero(double valTranspAero)
        {
            this.ValTranspAero = valTranspAero;
        }


        public void setValMillas(double valMillas)
        {
            this.ValMillas = valMillas;
        }

        public double getValMillas()
        {
            return ValMillas;
        }


#endregion   
    }


}
