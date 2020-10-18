using Practica1.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Tours : Form
    {

        Herencia objH = new Herencia();
        Avion objA = new Avion();
        Barco objB = new Barco();
        double Camarote = 0;
        double Habitacion = 0;
        double valor = 0;
        //double VM = 0;
        // double VImp = 0;

        public Tours()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void validarDestino()
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbAvion.Checked)
            {
                btIngDestino.Enabled = true;
                gbInfo.Enabled = true;
                txDiasDViaje.Enabled = false;
                txNom.Enabled = false;
                txCed.Enabled = false;
                gbTranspB.Enabled = false;
                btCalcular.Enabled = false;
                btEnviar.Enabled = false;
                
               

                MessageBox.Show("A continuación adjunte el destino de Viaje");


            }
            else if (rbbarco.Checked)
            {
                btIngDestino.Enabled = true;
                gbInfo.Enabled = true;
                txNom.Enabled = false;
                txCed.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                txDiasDViaje.Enabled = true;
                btCalcular.Enabled = false;
                txvalDiaBarco.Enabled = true;
                btEnviar.Enabled = false;
                
                MessageBox.Show("A continuación adjunte el destino de Viaje");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region AVION


            if (rbAvion.Checked)
            {

                try
                {
                    //validando campos nulos


                    if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                       || string.IsNullOrEmpty(txDiasEstadia.Text) || string.IsNullOrEmpty(txValMil.Text)
                       || string.IsNullOrEmpty(txTasaAero.Text) || string.IsNullOrEmpty(txTransAe.Text) ||
                       string.IsNullOrEmpty(txMillasCliente.Text))
                    {
                        MessageBox.Show("Debe diligenciar todo el formulario");
                    }
                    else
                    {
                        //enviando a constructores

                        objH.setNombre(txNom.Text);

                        objH.setCedula(Convert.ToDouble(txCed.Text));

                        objH.setDestino(txDest.Text);

                        objH.setDiasEsta(Convert.ToInt32(txDiasEstadia.Text));

                        objH.setMillas(Convert.ToInt32(txMillasCliente.Text));

                        objA.setValMillas(Convert.ToInt32(txValMil.Text));

                        objA.setValTasaAer(Convert.ToDouble(txTasaAero.Text));

                        objA.setValTranspAero(Convert.ToDouble(txTransAe.Text));

                    
                        if (rbLujo.Checked == true)
                        {
                            objH.setTCamarote("lujo");
                        }

                        if (rbNormal.Checked == true)
                        {
                            objH.setTCamarote("normal");
                        }

                        if (rbEconomco.Checked == true)
                        {
                            objH.setTCamarote("economico");
                        }

                        //Validacion tipo de Habitacion

                        if (rbSuite.Checked == true)
                        {
                            objH.setTHabitacion("suite");
                        }

                        if (rbHabNorm.Checked == true)
                        {
                            objH.setTHabitacion("normal");
                        }

                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("El valor ingresado no es el esperado" + fe);
                }



                if (objH.getTCamarote() == "lujo")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 90000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";

                }
                else if (objH.getTCamarote() == "normal")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 70000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }
                else if (objH.getTCamarote() == "economico")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 50000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }


                if (objH.getTHabitacion() == "suite")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 120000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";

                }
                else if (objH.getTHabitacion() == "normal")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 60000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";
                }

                double VM = (objA.getValMillas() * Convert.ToDouble(objH.getMillas()));
                double VImp = (objA.getValTranspAero() + objA.getValTasaAer());
                double Total = (Habitacion + Camarote + VImp + valor) - VM;


                txSalidaFinal.Text = "El valor por servicio de habitacion es : $ " + Habitacion + "\r\n" +
                    "El valor por el servicio de Tipo de Camarote es : $ " + Camarote + "\r\n" +
                    "El cliente tiene un valor acumulado por millas de : $ " + VM + "\r\n" +
                    "Valores por tasa aeropuertuaria y transporte aeropuerto de : $" + VImp + "\r\n" +
                    "Con un valor de tiquete fijo de viaje de hacia : " + txDest.Text + " por un valor de : $ " + valor + "\r\n" +
                    "Realizados los descuentos por valor de millas al cliente, el valor a cancelar por este es de \r\n" +
                    " $ "+Total;


                txNom.Text = "";
                txCed.Text = "";
                txDest.Text = "";
                txDiasEstadia.Text = "";
                txDiasDViaje.Text = "";
                txMillasCliente.Text = "";
                txValMil.Text = "";
                txTasaAero.Text = "";
                txTransAe.Text = "";
                txTransMu.Text = "";
                txValor.Text = "";
                txvalDiaBarco.Text = "";
                gbFecha.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                gbInfo.Enabled = false;
                gbTipoCama.Enabled = false;
                gbTipoHab.Enabled = false;
                btEnviar.Enabled = true;

            }
            #endregion

            #region BARCO
            else if (rbbarco.Checked)
            {
                try
                {
                    //validando campos nulos


                    if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                       || string.IsNullOrEmpty(txDiasEstadia.Text) || string.IsNullOrEmpty(txDiasDViaje.Text) || string.IsNullOrEmpty(txTransMu.Text)
                       || string.IsNullOrEmpty(txMillasBarco.Text) || string.IsNullOrEmpty(txValorMBarco.Text))
                    {
                        MessageBox.Show("Debe diligenciar todo el formulario");
                    }
                    else
                    {
                        //enviando a constructores

                        objH.setNombre(txNom.Text);

                        objH.setCedula(Convert.ToDouble(txCed.Text));

                        objH.setDestino(txDest.Text);

                        objH.setDiasEsta(Convert.ToInt32(txDiasEstadia.Text));

                        objB.setDiasViaje(Convert.ToInt32(txDiasDViaje.Text));

                        objB.setValorMillasBarco(Convert.ToDouble(txValorMBarco.Text));

                        objB.setMillasBarco(Convert.ToInt32(txMillasBarco.Text));

                                               
                        objB.setValTranspAMuelle(Convert.ToDouble(txTransMu.Text));

                        
                        if (rbLujo.Checked == true)
                        {
                            objH.setTCamarote("lujo");
                        }

                        if (rbNormal.Checked == true)
                        {
                            objH.setTCamarote("normal");
                        }

                        if (rbEconomco.Checked == true)
                        {
                            objH.setTCamarote("economico");
                        }

                        //Validacion tipo de Habitacion

                        if (rbSuite.Checked == true)
                        {
                            objH.setTHabitacion("suite");
                        }

                        if (rbHabNorm.Checked == true)
                        {
                            objH.setTHabitacion("normal");
                        }

                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("El valor ingresado no es el esperado" + fe);
                }



                if (objH.getTCamarote() == "lujo")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 90000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";

                }
                else if (objH.getTCamarote() == "normal")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 70000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }
                else if (objH.getTCamarote() == "economico")
                {
                    Camarote = Convert.ToDouble(objH.getDiasEsta() * 50000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }


                if (objH.getTHabitacion() == "suite")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 120000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";

                }
                else if (objH.getTHabitacion() == "normal")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 60000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";
                }

                double VM = (objB.getValorMillasBarco() * Convert.ToDouble(objB.getMillasBarco()));
                double VImp = objB.getValTranspAMuelle();
                double Total = (Habitacion + Camarote + VImp + valor) - VM;




                txSalidaFinal.Text = "El valor por servicio de habitacion es : $ " + Habitacion + "\r\n" +
                    "El valor por el servicio de Tipo de Camarote es : $ " + Camarote + "\r\n" +
                    "El cliente tiene un valor acumulado por millas de: $ " + VM + "\r\n" +
                    "El valor de transporte al muelle es de un valor : $ " + VImp + "\r\n" +
                    "Con un valor de tiquete fijo de viaje de hacia " + txDest.Text + " por un valor de : $ " + valor + "\r\n" +
                    "Realizados los descuentos por valor de millas al cliente el valor a cancelar por este es de \r\n" +
                    " $ "+Total;


                txNom.Text = "";
                txCed.Text = "";
                txDest.Text = "";
                txDiasEstadia.Text = "";
                txDiasDViaje.Text = "";
                txValorMBarco.Text = "";
                txMillasBarco.Text = "";
                txTransMu.Text = "";
                txValor.Text = "";
                txvalDiaBarco.Text = "";
                gbFecha.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                gbInfo.Enabled = false;
                gbTipoCama.Enabled = false;
                gbTipoHab.Enabled = false;
                btEnviar.Enabled = true;

                #endregion
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txDest.Text))
            {
                MessageBox.Show("Debe Seleccionar el lugar a Viajar para continuar");
                btEnviar.Enabled = true;

            }
            else if (txDest.Text == "Berlin")
            {

                valor = 5000000;
                txValor.Text = Convert.ToString(valor);

                if (rbAvion.Checked)
                {
                    //se que este proceso no es optimo, pero ya habia creado todo y se me habia pasado este paso por eso lo reiterativo del proceso
                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTransAv.Enabled = true;
                    txDiasDViaje.Enabled = false;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTranspB.Enabled = false;
                    
                    btCalcular.Enabled = true;


                }
                else if (rbbarco.Checked)
                {

                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTranspB.Enabled = true;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTransAv.Enabled = false;
                    txDiasDViaje.Enabled = true;
                    btCalcular.Enabled = true;

                }
            }
            else if (txDest.Text == "Londres")
            {

                valor = 4000000;
                txValor.Text = Convert.ToString(valor);

                if (rbAvion.Checked)
                {

                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTransAv.Enabled = true;
                    txDiasDViaje.Enabled = false;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTranspB.Enabled = false;
                    btCalcular.Enabled = true;

                }
                else if (rbbarco.Checked)
                {
                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTranspB.Enabled = true;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTransAv.Enabled = false;
                    txDiasDViaje.Enabled = true;
                    btCalcular.Enabled = true;
                }
            }
            else if (txDest.Text == "Praga")
            {

                valor = 6000000;
                txValor.Text = Convert.ToString(valor);

                if (rbAvion.Checked)
                {

                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTransAv.Enabled = true;
                    txDiasDViaje.Enabled = false;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTranspB.Enabled = false;
                    btCalcular.Enabled = true;

                }
                else if (rbbarco.Checked)
                {
                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTranspB.Enabled = true;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTransAv.Enabled = false;
                    txDiasDViaje.Enabled = true;
                    btCalcular.Enabled = true;
                }
            }
            else if (txDest.Text == "Roma")
            {

                valor = 5500000;
                txValor.Text = Convert.ToString(valor);

                if (rbAvion.Checked)
                {

                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTransAv.Enabled = true;
                    txDiasDViaje.Enabled = false;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTranspB.Enabled = false;
                    btCalcular.Enabled = true;

                }
                else if (rbbarco.Checked)
                {
                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTranspB.Enabled = true;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTransAv.Enabled = false;
                    txDiasDViaje.Enabled = true;
                    btCalcular.Enabled = true;
                }


            }

            txDest.Text = "";
            btIngDestino.Enabled = false;
        }

    }


}





