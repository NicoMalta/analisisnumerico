using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Xi_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
            Xi_textbox.Text = "";
        }

        private void Xd_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
            Xd_textbox.Text = "";
        }

        private void iter_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
            iteraciones_textbox.Text = "";
        }

        private void error_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
            tolerancia_textbox.Text = "";
        }
    }
}
