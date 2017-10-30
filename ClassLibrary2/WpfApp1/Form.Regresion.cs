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
            dataGridView2.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            // dataGridView2
            while (dataGridView2.RowCount > 1)
            {

                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            }
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

            var a = regresion.RL_MinimosCuadrados(listax, listay);
            dataGridView2.ColumnCount = 2;
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.Columns[0].HeaderText = "Y";
            dataGridView2.Columns[1].HeaderText = "X";
            dataGridView2.Rows[0].Cells[0].Value = a[0];
            dataGridView2.Rows[0].Cells[1].Value = a[1];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            while (dataGridView2.RowCount > 1)
            {

                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            }

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

            var a = regresion.RP_MinimoCuadrados(listax, listay, Convert.ToDouble(error.Text));
            dataGridView2.ColumnCount = a.Count();
            dataGridView2.AllowUserToAddRows = true;
            for (int i = 0; i < a.Count; i++)
            {
                dataGridView2.Columns[i].HeaderText = "a" + i;
                dataGridView2.Rows[0].Cells[i].Value = a[i];
            }
            dataGridView2.Columns[a.Count - 1].HeaderText = "Coef. Correlacion";
            dataGridView2.Rows[0].Cells[a.Count - 1].Value = a[a.Count() - 1];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regresion regresion = new Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            while (dataGridView2.RowCount > 1)
            {

                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            }
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

            var a = regresion.CalLagrange(listax, listay, Convert.ToDouble(imagen.Text));

            dataGridView2.ColumnCount = 1;
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.Columns[0].HeaderText = "Y0";

            dataGridView2.Rows[0].Cells[0].Value = a;

        }

        private void FormRegresion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
