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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();

            a.Show();
        }

        private void entro(object sender, MouseEventArgs e)
        {
            label_biseccion.FontStyle = FontStyles.Italic;
        }

        private void salgo(object sender, MouseEventArgs e)
        {

            label_biseccion.FontStyle = FontStyles.Normal;
        }

        private void label_biseccion_Click(object sender, RoutedEventArgs e)
        {

            Window1 nuevo = new Window1();
            nuevo.Show();
            this.Close();
        }
    }
}
