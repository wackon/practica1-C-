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

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                   || string.IsNullOrEmpty(txDiasEstadia.Text) || string.IsNullOrEmpty(txDiasDViaje.Text) || string.IsNullOrEmpty(txValMil.Text)
                   || string.IsNullOrEmpty(txTasaAero.Text) || string.IsNullOrEmpty(txTransAe.Text) || string.IsNullOrEmpty(txTransMu.Text) ||
                   string.IsNullOrEmpty(txMillasCliente.Text))
                {
                    MessageBox.Show("Debe diligenciar todo el formulario");
                }
                else
                {
                    objH.setNombre(txNom.Text);

                    objH.setCedula(txCed.Text);

                    objH.setDestino(txDest.Text);

                    objH.setDiasEsta(Convert.ToInt32(txDiasEstadia.Text));

                    objH.setDiasViaje(Convert.ToInt32(txDiasDViaje.Text));

                    objH.setMillas(Convert.ToInt32(txMillasCliente.Text));

                    objA.setValMillas(Convert.ToInt32(txValMil.Text));

                    objA.setValTasaAer(Convert.ToDouble(txTasaAero.Text));

                    objA.setValTasaAer(Convert.ToDouble(txTransAe.Text));

                    objA.setValTasaAer(Convert.ToDouble(txTransMu.Text));


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
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("El valor ingresado no es el esperado" + fe);
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

            if (objH.getTCamarote() == "lujo")
            {
                MessageBox.Show("lujo");

            }
            else if (objH.getTCamarote() == "normal")
            {
                MessageBox.Show("normal");
            }
            else if (objH.getTCamarote() == "economico")
            {
                MessageBox.Show("economico");
            }

        }
    }


}



