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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool ContadorClick_biseccion { get; set; }
        public bool ContadorClick_reglafalsa { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void entro(object sender, MouseEventArgs e)
        {
           //    label_biseccion.FontStyle = FontStyles.Italic;
        }

        private void salgo(object sender, MouseEventArgs e)
        {

           // label_biseccion.FontStyle = FontStyles.Normal;
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
            //Window1 a = new Window1();
            //a.Show();
            //this.Close();
            ContadorClick_reglafalsa = false;
            var bc = new BrushConverter();
            if (ContadorClick_biseccion == false)
            {
               
                biseccion.Background = (Brush)bc.ConvertFrom("#FF343131");
                grid2.Visibility = Visibility.Visible;
                grid3.Visibility = Visibility.Hidden;
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
                ContadorClick_biseccion = true;
            }
            else
            {
                grid2.Visibility = Visibility.Hidden;
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
                ContadorClick_biseccion = false;
            }

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
            var bc = new BrushConverter();
            biseccion.Background = (Brush)bc.ConvertFrom("#FF343131");
        }

        private void White_Biseccion(object sender, MouseEventArgs e)
        {
            if (ContadorClick_biseccion == false)
            {
                var bc = new BrushConverter();
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
            }
        }

        private void reglaFalsa_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            ContadorClick_biseccion = false;
            if (ContadorClick_reglafalsa == false)
            {
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF343131");
                grid3.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Hidden;
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
                ContadorClick_reglafalsa = true;
            }
            else
            {
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
                grid3.Visibility = Visibility.Hidden;
                ContadorClick_reglafalsa = false;
            }

        }

        private void ReglaFalsa_Grey(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            regla_falsa.Background = (Brush)bc.ConvertFrom("#FF343131");
        }

        private void ReglaFalsa_White(object sender, MouseEventArgs e)
        {
            if (ContadorClick_reglafalsa == false)
            {
                var bc = new BrushConverter();
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
            }

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
            ResultadoRaizCerrados resultado = new ResultadoRaizCerrados(Convert.ToInt32(iteraciones_textbox_biseccion.Text), Convert.ToInt32(tolerancia_textbox_biseccion.Text));
            resultado.XI = Convert.ToInt32(Xi_textbox_biseccion.Text);
            resultado.XD = Convert.ToInt32(Xd_textbox_biseccion.Text);
            Function f = new Function("f(x) = " + fx_biseccion_textbox.Text);
          
            
            var Metodos = new Metodos();

            Metodos.Biseccion(resultado, f);

            Resultado_label_biseccion.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_biseccion.Content = "Error: " + resultado.error;
            Resultado_label_biseccion.Visibility = Visibility.Visible;
            ResultadoError_label_biseccion.Visibility = Visibility.Visible;
        }

        private void tolerancia_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void fx_biseccion_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            fx_biseccion_textbox.Text = "";
        }


        private void Xi_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Xi_textbox_biseccion.Text = "";
            Xi_textbox_reglafalsa.Text = "";
        }

        private void Xd_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Xd_textbox_biseccion.Text = "";
            Xd_textbox_reglafalsa.Text = "";
        }

        private void iteraciones_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            iteraciones_textbox_biseccion.Text = "";
            iteraciones_textbox_reglafalsa.Text = "";
        }

        private void tolerancia_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tolerancia_textbox_biseccion.Text = "";
            tolerancia_textbox_reglafalsa.Text = "";
        }

        private void ResolverRF(object sender, RoutedEventArgs e)
        {
            ResultadoRaizCerrados resultado = new ResultadoRaizCerrados(Convert.ToInt32(iteraciones_textbox_reglafalsa.Text), Convert.ToInt32(tolerancia_textbox_reglafalsa.Text));
            resultado.XI = Convert.ToInt32(Xi_textbox_reglafalsa.Text);
            resultado.XD = Convert.ToInt32(Xd_textbox_reglafalsa.Text);
            Function f = new Function("f(x) = " + fx_biseccion_textbox.Text);
            var Metodos = new Metodos();

            Metodos.ReglaFalsa(resultado, f);

            Resultado_label_reglafalsa.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_reglafalsa.Content = "Error: " + resultado.error;
            Resultado_label_reglafalsa.Visibility = Visibility.Visible;
            ResultadoError_label_reglafalsa.Visibility = Visibility.Visible;
        }

        private void fx_reglafalsa_textbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            fx_reglafalsa_textbox.Text = "";
        }
    }
}
