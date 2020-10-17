using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Barco : Herencia
    {
        int diasViaje = 0;
        double ValTranspAMuelle =0;

        public Barco(string destino, string nombre, double cedula,  int diasEsta, string tCamarote, string tHabitacion, string fechaViaje, double valorTransporte,
           int millas, double valorDias, double ValTranspAMuelle,int diasViaje) : base(destino, nombre, cedula,  diasEsta, tCamarote, tHabitacion, fechaViaje, valorTransporte,millas)
        {
            this.diasViaje = diasViaje;
            this.ValTranspAMuelle = ValTranspAMuelle;
        }

        public Barco()
        {
        }

        


        #region GETTER AND SETTERS
      public void setDiasViaje(int diasViaje)
        {
            this.diasViaje = diasViaje;
        }

        public int getDiasViaje()
        {
            return diasViaje;
        }
       
        public void setValTranspAMuelle(double ValTranspAMuelle)
        {
            this.ValTranspAMuelle = ValTranspAMuelle;
        }

        public double getValTranspAMuelle()
        {
            return ValTranspAMuelle;
        }
        #endregion

    }

}
