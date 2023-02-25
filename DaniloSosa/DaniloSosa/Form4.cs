using System;
using System.Windows.Forms;

namespace DaniloSosa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void verbutton_Click(object sender, EventArgs e)
        {
            RecorrerUnoAUno(1, 100);
        }
        private void RecorrerUnoAUno(int valorInicial, int valorFinal)
        {


            if (valorInicial < valorFinal)
            {
                if (valorInicial % 3 == 0 && valorInicial % 5 == 0)
                {
                    listBox1.Items.Add("Danilo Sosa");
                }
                else if (valorInicial % 5 == 0)
                {
                    listBox1.Items.Add("Sosa");
                }
                else if (valorInicial % 3 == 0)
                {
                    listBox1.Items.Add("Danilo ");
                }
                else
                {
                    listBox1.Items.Add(valorInicial);
                }




                RecorrerUnoAUno(valorInicial + 1, valorFinal);


            }


        }

    }


}



