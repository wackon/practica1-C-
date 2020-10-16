using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Barco : Herencia
    {
        double valorDias = 0;
        double ValTranspAMuelle =0;

        public Barco(string destino, string nombre, string cedula, int diasViaje, int diasEsta, string tCamarote, string tHabitacion, string fechaViaje, double valorTransporte,
           int millas, double valorDias, double ValTranspAMuelle) : base(destino, nombre, cedula, diasViaje, diasEsta, tCamarote, tHabitacion, fechaViaje, valorTransporte,millas)
        {
            this.valorDias = valorDias;
            this.ValTranspAMuelle = ValTranspAMuelle;
        }

        public Barco()
        {
        }



        #region GETTER AND SETTERS
        public void setValorDias(double valorDias)
        {
            this.valorDias = valorDias;
        }

        public double getValorDias()
        {
            return valorDias;
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
