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
    public partial class Grilla : Form
    {
        public Grilla()
        {
            InitializeComponent();

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int elem;
            var esValido = int.TryParse(dataGridView1.Rows[0].Cells[0].Value.ToString(), out elem);

            if (esValido)
            {
                
            }

            Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(textBox1.Text) + 1;
            dataGridView1.RowHeadersVisible = false;
     
            for (int i = 0; i < Convert.ToInt32(textBox1.Text) + 1; i++)
            {
                
                dataGridView1.Columns[i].HeaderText = "x" + i;
               
                if ((Convert.ToInt32(textBox1.Text)) == i)
                {
                    dataGridView1.Columns[i].HeaderText = "Resultado";
                }
                
            }

            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double[,] aux = new double[Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text) + 1];

            for (int c = 0; c <= Convert.ToInt32(textBox1.Text)-1; c++)
            {
                for (int f = 0; f <= Convert.ToInt32(textBox1.Text); f++)
                {
                    double elem;
                    var esValido = double.TryParse(dataGridView1.Rows[c].Cells[f].Value.ToString(), out elem);
                    
                    if (esValido)
                    {
                        aux[c, f] = elem;
                    }

                }
            }
        }
    }
}
