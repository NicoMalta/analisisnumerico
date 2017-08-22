using ClassLibrary2;
using org.mariuszgromada.math.mxparser;
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
           
        }

        private void Xd_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void iter_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void error_textbox_MouseEnter(object sender, MouseEventArgs e)
        {
        
        }

        private void hacerclick(object sender, RoutedEventArgs e)
        {
            ResultadoRaiz resultado = new ResultadoRaiz(Convert.ToInt32(iteraciones_textbox.Text), Convert.ToInt32(tolerancia_textbox.Text));
            resultado.XI = Convert.ToInt32(Xi_textbox.Text);
            resultado.XD = Convert.ToInt32(Xd_textbox.Text);

            var Metodos = new Metodos();

            Metodos.Biseccion(resultado);

            Resultado_label.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label.Content = "Error: " + resultado.error;
            Resultado_label.Visibility = Visibility.Visible;
            ResultadoError_label.Visibility = Visibility.Visible;
        }

        private void tolerancia_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Xi_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Xi_textbox.Text = "";
        }

        private void Xd_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Xd_textbox.Text = "";
        }

        private void iteraciones_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            iteraciones_textbox.Text = "";
        }

        private void tolerancia_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tolerancia_textbox.Text = "";
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
          
            this.Close();
            
        }
    }
}
