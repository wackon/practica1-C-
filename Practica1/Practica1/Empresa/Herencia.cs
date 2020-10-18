using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Herencia
    {
        string Destino = "";
        string nombre = "";
        string TCamarote = "";
        string THabitacion = "";
        string FechaViaje = "";
        double Cedula =0;
       // int DiasViaje = 0;
        int DiasEsta = 0;
        int Millas = 0;
        double ValorTransporte;



        public Herencia(string destino, string nombre, double cedula, int diasEsta,
                        string tCamarote, string tHabitacion, string fechaViaje, double valorTransporte, int millas)
        {
            this.Destino = destino;
            this.nombre = nombre;
            this.Cedula = cedula;
            this.Millas = millas;
            this.DiasEsta = diasEsta;
            this.TCamarote = tCamarote;
            this.THabitacion = tHabitacion;
            this.FechaViaje = fechaViaje;
            this.ValorTransporte = valorTransporte;

        }

        public Herencia()
        {

        }

        #region GETTERS AND SETTERS    

        public void setDestino(string destino)
        {
            this.Destino = destino;
        }

        public string getDestino()
        {
            return Destino;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setCedula(double cedula)
        {
            this.Cedula = cedula;
        }

        public double getCedula()
        {
            return Cedula;
        }

      /*  public void setDiasViaje(int diasViaje)
        {
            this.DiasViaje = diasViaje;
        }

        public int getDiasViaje()
        {
            return DiasViaje;
        }*/

        public void setDiasEsta(int diasEsta)
        {
            this.DiasEsta = diasEsta;
        }

        public int getDiasEsta()
        {
            return DiasEsta;
        }

        public void setTCamarote(string tCamarote)
        {
            this.TCamarote = tCamarote;
        }

        public string getTCamarote()
        {
            return TCamarote;
        }

        public void setTHabitacion(string tHabitacion)
        {
            this.THabitacion = tHabitacion;
        }

        public string getTHabitacion()
        {
            return THabitacion;
        }

        /* public void setTEstadia(string estadia)
         {
             this.Estadia = estadia;
         }

         public string getEstadia()
         {
             return Estadia;
         }*/

        public void setFechaViaje(string fechaViaje)
        {
            this.FechaViaje = fechaViaje;
        }

        public string getFechaViaje()
        {
            return FechaViaje;
        }

        public void setValorTransporte(double valorTransporte)
        {
            this.ValorTransporte = valorTransporte;
        }

        public double getValorTransporte()
        {
            return ValorTransporte;
        }

        public void setMillas(int millas)
        {
            this.Millas = millas;
        }

        public int getMillas()
        {
            return Millas;
        }

 #endregion
            

       


    }
}
