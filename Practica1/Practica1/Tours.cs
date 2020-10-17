using Practica1.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                gbInfo.Enabled = true;
                gbTipoCama.Enabled = true;
                gbTipoHab.Enabled = true;
                gbFecha.Enabled = true;
                gbTransAv.Enabled = true;
                txDiasDViaje.Enabled = false;
                gbTranspB.Enabled = false;


            }
            else if (rbbarco.Checked)
            {
                gbInfo.Enabled = true;
                gbTipoCama.Enabled = true;
                gbTipoHab.Enabled = true;
                gbFecha.Enabled = true;
                gbTranspB.Enabled = true;
                gbTransAv.Enabled = false;
                txDiasDViaje.Enabled = true;

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

                    //|| string.IsNullOrEmpty(txDiasDViaje.Text) || string.IsNullOrEmpty(txTransMu.Text) ||


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

                        objA.setValTasaAer(Convert.ToDouble(txTransAe.Text));

                        // objH.setDiasViaje(Convert.ToInt32(txDiasDViaje.Text));

                        // objA.setValTasaAer(Convert.ToDouble(txTransMu.Text));

                        //Validacion tipo de Camarote

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



            }
            #endregion

            #region BARCO
            else if (rbbarco.Checked)
            {
                try
                {
                    //validando campos nulos


                    if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                       || string.IsNullOrEmpty(txDiasEstadia.Text) || string.IsNullOrEmpty(txDiasDViaje.Text) || string.IsNullOrEmpty(txTransMu.Text))
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

                        //objH.setMillas(Convert.ToInt32(txMillasCliente.Text));

                        // objA.setValMillas(Convert.ToInt32(txValMil.Text));

                        //objA.setValTasaAer(Convert.ToDouble(txTasaAero.Text));

                        //objA.setValTasaAer(Convert.ToDouble(txTransAe.Text));

                        objB.setValTranspAMuelle(Convert.ToDouble(txTransMu.Text));

                        //Validacion tipo de Camarote

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

                #endregion
            }

        }
    }


}



