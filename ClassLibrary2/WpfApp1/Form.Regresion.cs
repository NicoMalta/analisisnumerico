using ClassLibrary2;
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
    public partial class FormRegresion : Form
    {
        public FormRegresion()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 1;
            dataGridView1.AutoSize = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].HeaderText = "Y";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                    double elem;
                    var esValido = double.TryParse(dataGridView1.Rows[c].Cells[0].Value.ToString(), out elem);

                    if (esValido)
                    {
                       listax.Add(elem);
                    }
            }
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                double elem;
                var esValido = double.TryParse(dataGridView1.Rows[c].Cells[1].Value.ToString(), out elem);

                if (esValido)
                {
                    listay.Add(elem);
                }
            }

           regresion.RL_MinimosCuadrados(listax,listay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                double elem;
                var esValido = double.TryParse(dataGridView1.Rows[c].Cells[0].Value.ToString(), out elem);

                if (esValido)
                {
                    listax.Add(elem);
                }
            }
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                double elem;
                var esValido = double.TryParse(dataGridView1.Rows[c].Cells[1].Value.ToString(), out elem);

                if (esValido)
                {
                    listay.Add(elem);
                }
            }

            regresion.RP_MinimoCuadrados(listax, listay, Convert.ToDouble(error.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                double elem;
                var esValido = double.TryParse(dataGridView1.Rows[c].Cells[0].Value.ToString(), out elem);

                if (esValido)
                {
                    listax.Add(elem);
                }
            }
            for (int c = 0; c < dataGridView1.RowCount - 1; c++)
            {
                double elem;
                var esValido = double.TryParse(dataGridView1.Rows[c].Cells[1].Value.ToString(), out elem);

                if (esValido)
                {
                    listay.Add(elem);
                }
            }

            regresion.CalLagrange(listax, listay, Convert.ToDouble(imagen.Text));
        }
    }
}
