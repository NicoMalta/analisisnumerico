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
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
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
    }
}
