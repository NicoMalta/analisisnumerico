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
           //    label_biseccion.FontStyle = FontStyles.Italic;
        }

        private void salgo(object sender, MouseEventArgs e)
        {

           // label_biseccion.FontStyle = FontStyles.Normal;
        }

        private void label_biseccion_Click(object sender, RoutedEventArgs e)
        {

            Window1 nuevo = new Window1();
            nuevo.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_click(object sender, RoutedEventArgs e)
        {
           
    }

        private void biseccion_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
            this.Close();
        }

        private void AgrandoCruz(object sender, MouseEventArgs e)
        {
            Cruz.FontSize = 20;
            Cruz.Foreground = Brushes.DarkGray;
        }

        private void AchicoCruz(object sender, MouseEventArgs e)
        {
            Cruz.FontSize = 18;
            Cruz.Foreground = Brushes.White;
        }

        private void Grey_Biseccion(object sender, MouseEventArgs e)
        {
            biseccion.Background = Brushes.DarkGray;
        }

        private void White_Biseccion(object sender, MouseEventArgs e)
        {
            biseccion.Background = Brushes.White;
        }

        private void reglaFalsa_Click(object sender, RoutedEventArgs e)
        {
            ReglaFalsa a = new ReglaFalsa();
            a.Show();
            this.Close();
        }

        private void ReglaFalsa_Grey(object sender, MouseEventArgs e)
        {
            regla_falsa.Background = Brushes.DarkGray;
        }

        private void ReglaFalsa_White(object sender, MouseEventArgs e)
        {
            regla_falsa.Background = Brushes.White;
        }
    }
}
