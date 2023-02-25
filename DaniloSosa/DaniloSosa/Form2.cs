using System;
using System.Windows.Forms;

namespace DaniloSosa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            decimal capital = 200000;
            decimal tasa = 0.015m;
            decimal tiempo = 1;
            decimal interes = 0;
            decimal acum = 0;


            for (int i = 1; i < 13; i++)
            {
                interes = capital * tasa * tiempo;


                listBox1.Items.Add(((short)interes));

                acum = interes + capital;
                capital = acum;
            }

            String[] vector = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosoto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < vector.Length; i++)
            {
                listBox2.Items.Add(vector[i]);
            }


        }


    }
}



