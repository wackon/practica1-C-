using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Avion : Herencia
    {
        int Millas = 0;
        double ValMillas = 0;
        double ValTasaAer = 0;
        double ValTranspAero=0;

        public Avion(string destino, string nombre, string cedula, int diasViaje, int diasEsta, string tCamarote, string tHabitacion,string fechaViaje, double valorTransporte,
            int millas, double valMillas, double valTasaAer, double valTranspAero) : base(destino, nombre, cedula, diasViaje, diasEsta, tCamarote, tHabitacion, fechaViaje, valorTransporte,millas)

        {

            this.ValMillas = valMillas;
            this.ValTasaAer = valTasaAer;
            this.ValTranspAero = valTranspAero;

        }

        public Avion()
        {
        }



        #region GETTER AND SETTERS
        /*public void setMillas(int millas)
        {
            this.Millas = millas;
        }

        public int getMillas()
        {
            return Millas;
        }*/


        public void setValMillas(double valMillas)
        {
            this.ValMillas = valMillas;
        }

        public double getValMillas()
        {
            return ValMillas;
        }

        public void setValTasaAer(double valTasaAer)
        {
            this.ValMillas = valTasaAer;
        }

        public double getValTasaAer()
        {
            return ValTasaAer;
        }
        public void setValTranspAero(double valTranspAero)
        {
            this.ValTranspAero = valTranspAero;
        }

        public double getValTranspAero()
        {
            return ValTranspAero;
        }

        #endregion
    }


}
