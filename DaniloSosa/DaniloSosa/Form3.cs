using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaniloSosa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {


            decimal pre1 = Convert.ToDecimal(precio1textBox.Text);
            decimal pre2 = Convert.ToDecimal(precio2textBox.Text);
            decimal pre3 = Convert.ToDecimal(precio3textBox.Text);
            decimal desc = 0.15m;


            decimal resultado = await DescuentoAzync(pre1, pre2, pre3, desc);
            MessageBox.Show($"El Descuento es: {resultado}");

            decimal totalapagar = await TotalAzync(pre1, pre2, pre3);
            MessageBox.Show($"El Total a Pagar es:{totalapagar}");
        }

        private async Task<decimal> DescuentoAzync(decimal precio1, decimal precio2, decimal precio3, decimal desc)
        {

            decimal suma = precio1 + precio2 + precio3;

            decimal descuento = await Task.Run(() =>
            {

                return suma * desc;

            });

            return descuento;


        }
        private async Task<decimal> TotalAzync(decimal precio1, decimal precio2, decimal precio3)
        {

            decimal sum = 0;
            decimal descu = 0;
            decimal total = await Task.Run(() =>
            {

                sum = precio1 + precio2 + precio3;
                descu = sum * 0.15m;
                return sum - descu;

            });

            return total;

        }
    }
}


