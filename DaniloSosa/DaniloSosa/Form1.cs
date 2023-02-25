using System.Windows.Forms;

namespace DaniloSosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void primerFormularioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form interes = new Form2();
            interes.Show();


        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void comprarProductoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form producto = new Form3();
            producto.Show();


        }

        private void numerosDel1Al100ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form numeros = new Form4();
            numeros.Show();
        }
    }
}
