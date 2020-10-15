using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica1
{
    public partial class Vista : Form
    {


        Books objB;
        Books[] vector = new Books[3];
        int contador = 0;
        bool Disponible;

        public Vista()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            try
            {


                if (string.IsNullOrEmpty(txIngCod.Text) || string.IsNullOrEmpty(txIngNom.Text) || string.IsNullOrEmpty(txIngAut.Text))
                {

                    MessageBox.Show("Digite todos los campos");
                }
                else
                {

                    string Codigo = txIngCod.Text;
                    string Nombre = txIngNom.Text;
                    string Autor = txIngAut.Text;



                    if (rbDisponible.Checked == true)
                    {
                        Disponible = true;
                    }
                    else
                    {
                        Disponible = false;
                    }


                    vector[contador] = new Books(Codigo, Nombre, Autor, Disponible);




                    txIngCod.Text = "";
                    txIngNom.Text = "";
                    txIngAut.Text = "";
                    contador += 1;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught.", ex);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {


            if (contador == 0)
            {
                System.Windows.Forms.MessageBox.Show("No existen Libros ingresados");

            }
            else if (string.IsNullOrEmpty(txBusCod.Text))
            {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

            }
            else
            {
                string cod = txBusCod.Text;


                for (int i = 0; i < vector.Length; i++)

                {
                    if (cod == vector[i].getCodigo())
                    {

                        txBusNombre.Text = vector[i].getNombre();
                        txBusAut.Text = vector[i].getAutor();
                        txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                    }

                }
            }



            /* foreach (Books vec in vector)
             {

                 txSalidaConsulta.Text = Convert.ToString(objB.getCodigo()) + "\r\n" +
                     "Nombre : " + Convert.ToString(objB.getNombre()) + "\r\n" +
                     "Autor : " + Convert.ToString(objB.getAutor()) + "\r\n" +
                     "Disponible : " + Convert.ToString(objB.getDisponible()) + "\r\n\r\n";

                 txSalidaConsulta.Text = txSalidaConsulta.Text + txSalidaConsulta.Text;


             }
            */



        }



        private void txBusNom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBusNombre.Text))
            {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

            }
            else
            {
                string nombre = txBusNombre.Text;


                for (int i = 0; i < vector.Length; i++)

                {
                    if (nombre == vector[i].getNombre())
                    {

                        txBusCod.Text = vector[i].getCodigo();
                        txBusAut.Text = vector[i].getAutor();
                        txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                    }

                }
            }
        }

        private void txBusAu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBusAut.Text))
            {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

            }
            else
            {
                string autor = txBusAut.Text;


                for (int i = 0; i < vector.Length; i++)

                {
                    if (autor == vector[i].getAutor())
                    {

                        txBusCod.Text = vector[i].getCodigo();
                        txBusNombre.Text = vector[i].getNombre();
                        txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                    }

                }
            }
        }

        private void txBusDis_Click(object sender, EventArgs e)
        {
            string salida = "";


            for (int i = 0; i < vector.Length; i++)

            {
                if ("True" == Convert.ToString(vector[i].getDisponible()))
                {


                    salida += "Los libros disponibles en la actualidad son : \r\n" +
                    "Codigo : " + vector[i].getCodigo() + "\r\n" +
                    "Nombre : " + vector[i].getNombre() + "\r\n" +
                    "Autor : " + vector[i].getAutor() + "\r\n\r\n";




                }

            }
            txSalidaConsulta.Text = salida;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txIngCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txEliminar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a eliminar");

            }
            else 
            {

                string cod = txEliminar.Text;

                for (int i = 0; i < vector.Length; i++)
                {
                    try
                    {

                        if (cod == vector[i].getCodigo())
                        {
                            contador -= 1;

                            for (int j = i; j < vector.Length - 1; j++)
                            {

                                
                                vector[j] = vector[j + 1];
                                MessageBox.Show("el elemento ha sido borrado");
                            }

                        }
                    }
                    catch (IOException ex)
                    { 

                    }
                    
                }
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPrestar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a Entregar");

            }
            else
            {

                string cod = txPrestar.Text;

                for (int i = 0; i < vector.Length; i++)
                {
                    

                        if (cod == vector[i].getCodigo())
                        {
                            vector[i].setDisponible(false);
                             
                        }
                    
                    }
                txPrestar.Text = "";
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txEntregar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a Entregar");

            }
            else
            {

                string cod = txEntregar.Text;

                for (int i = 0; i < vector.Length; i++)
                {


                    if (cod == vector[i].getCodigo())
                    {
                        vector[i].setDisponible(true);

                    }

                }
                 txEntregar.Text = "";

            }
        }

        private void txEntregar_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



