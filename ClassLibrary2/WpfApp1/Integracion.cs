using ClassLibrary2;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class Integracion : Form
    {
        public Integracion()
        {
            InitializeComponent();
        }

        private void txt_funcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_ts_Click(object sender, EventArgs e)
        {
            var integrar = new IntegracionNumerica();
            lbl_resultado.Text = Convert.ToString(integrar.TrapeciosSimple(Convert.ToDouble(txt_a.Text),Convert.ToDouble(txt_b.Text),new Function("f(x) = "+txt_funcion.Text)));
        }

        private void bttn_tm_Click(object sender, EventArgs e)
        {
            var integrar = new IntegracionNumerica();
            lbl_resultado.Text = Convert.ToString(integrar.TrapeciosMultiple(Convert.ToDouble(txt_a.Text), Convert.ToDouble(txt_b.Text), new Function("f(x) = " + txt_funcion.Text),Convert.ToInt32(txt_n.Text)));
        }

        private void bttn_s13_Click(object sender, EventArgs e)
        {
            var integrar = new IntegracionNumerica();
            lbl_resultado.Text = Convert.ToString(integrar.Simpson13(Convert.ToDouble(txt_a.Text), Convert.ToDouble(txt_b.Text), new Function("f(x) = " +txt_funcion.Text)));
        }

        private void bttn_s13m_Click(object sender, EventArgs e)
        {
            var integrar = new IntegracionNumerica();
            lbl_resultado.Text = Convert.ToString(integrar.Simpson13Multiple(Convert.ToDouble(txt_a.Text), Convert.ToDouble(txt_b.Text), new Function("f(x) = "+txt_funcion.Text), Convert.ToInt32(txt_n.Text)));
        }

        private void bttn_s38_Click(object sender, EventArgs e)
        {
            var integrar = new IntegracionNumerica();
            lbl_resultado.Text = Convert.ToString(integrar.Simpson38(Convert.ToDouble(txt_a.Text), Convert.ToDouble(txt_b.Text), new Function("f(x) = "+txt_funcion.Text)));
        }
    }
}
