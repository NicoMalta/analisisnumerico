using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultadoRaiz resultado = new ResultadoRaiz(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            resultado.XI = Convert.ToInt32(textBox3.Text);
            resultado.XD = Convert.ToInt32(textBox4.Text);

            var Metodos = new Metodos();

            Metodos.Biseccion(resultado);

            label3.Text = Convert.ToString(resultado.valorRaiz);
        }


    }
}
