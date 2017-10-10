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
        public bool ContadorClick_tangente { get; set; }
        public bool ContadorClick_Secante { get; set; }
        public bool ContadorClick_Ecuaciones { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void biseccion_Click(object sender, RoutedEventArgs e)
        {
            //Window1 a = new Window1();
            //a.Show();
            //this.Close();
            ContadorClick_reglafalsa = false;
            ContadorClick_tangente = false;
            ContadorClick_Secante = false;
            ContadorClick_Ecuaciones = false;
            var bc = new BrushConverter();
            if (ContadorClick_biseccion == false)
            {
               
                biseccion.Background = (Brush)bc.ConvertFrom("#FF343131");
                grid2.Visibility = Visibility.Visible;
                grid3.Visibility = Visibility.Hidden;
                grid4.Visibility = Visibility.Hidden;
                grid5.Visibility = Visibility.Hidden;
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF232323");
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
            ContadorClick_tangente = false;
            ContadorClick_Secante = false;
            ContadorClick_Ecuaciones = false;

            if (ContadorClick_reglafalsa == false)
            {
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF343131");
               
                grid3.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Hidden;
                grid4.Visibility = Visibility.Hidden;
                grid5.Visibility = Visibility.Hidden;
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF232323");
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

        private void hacerclick(object sender, RoutedEventArgs e)
        {
            ResultadoRaizCerrados resultado = new ResultadoRaizCerrados(Convert.ToInt32(iteraciones_textbox_biseccion.Text), Convert.ToDouble(tolerancia_textbox_biseccion.Text));
            resultado.XI = Convert.ToDouble(Xi_textbox_biseccion.Text);
            resultado.XD = Convert.ToDouble(Xd_textbox_biseccion.Text);
            Function f = new Function("f(x) = " + fx_biseccion_textbox.Text);
          
            
            var Metodos = new Metodos();

            resultado = Metodos.Biseccion(resultado, f);

            Resultado_label_biseccion.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_biseccion.Content = "Error: " + resultado.error;
            iterusadas_bis_label.Content = "Iteraciones: " + resultado.iteraciones;
            Resultado_label_biseccion.Visibility = Visibility.Visible;
            ResultadoError_label_biseccion.Visibility = Visibility.Visible;
            iterusadas_bis_label.Visibility = Visibility.Visible;
        }



        private void ResolverRF(object sender, RoutedEventArgs e)
        {
            ResultadoRaizCerrados resultado = new ResultadoRaizCerrados(Convert.ToInt32(iteraciones_textbox_reglafalsa.Text), Convert.ToDouble(tolerancia_textbox_reglafalsa.Text));
            resultado.XI = Convert.ToDouble(Xi_textbox_reglafalsa.Text);
            resultado.XD = Convert.ToDouble(Xd_textbox_reglafalsa.Text);
            Function f = new Function("f(x) = " + fx_reglafalsa_textbox.Text);
            var Metodos = new Metodos();

            Metodos.ReglaFalsa(resultado, f);

            Resultado_label_reglafalsa.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_reglafalsa.Content = "Error: " + resultado.error;
            iterusadas_rf_label.Content = "Iteraciones: " + resultado.iteraciones;
            Resultado_label_reglafalsa.Visibility = Visibility.Visible;
            ResultadoError_label_reglafalsa.Visibility = Visibility.Visible;
            iterusadas_rf_label.Visibility = Visibility.Visible;
        }


        private void Grey_Tangente(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Tangente_button.Background = (Brush)bc.ConvertFrom("#FF343131");
        }

        private void White_Tangente(object sender, MouseEventArgs e)
        {
            if (ContadorClick_tangente == false)
            {
                var bc = new BrushConverter();
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF232323");
            }
        }

        private void Resolver_Tangente_Click(object sender, RoutedEventArgs e)
        {
            ResultadoRaizAbiertos resultado = new ResultadoRaizAbiertos(Convert.ToInt32(iteraciones_tan_textbox.Text), Convert.ToDouble(error_tan_textbox.Text));
            resultado.Xini = Convert.ToDouble(xini_textbox.Text);

            Function f = new Function("f(x) = " + fx_tan_textbox.Text);
            var Metodos = new Metodos();

            Metodos.Tangente(resultado, f);

            Resultado_label_tan.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_tan.Content = "Error: " + resultado.error;
            iterusadas_tan_label.Content = "Iteraciones: " + resultado.iteraciones;
            Resultado_label_tan.Visibility = Visibility.Visible;
            ResultadoError_label_tan.Visibility = Visibility.Visible;
            iterusadas_tan_label.Visibility = Visibility.Visible;
        }

        private void Tangente_button_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            ContadorClick_biseccion = false;
            ContadorClick_reglafalsa = false;
            ContadorClick_Secante = false;
            ContadorClick_Ecuaciones = false;

            if (ContadorClick_tangente == false)
            {
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF343131");
                grid4.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Hidden;
                grid3.Visibility = Visibility.Hidden;
                grid5.Visibility = Visibility.Hidden;
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
                ContadorClick_tangente = true;
            }
            else
            {
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF232323");
                grid4.Visibility = Visibility.Hidden;
                ContadorClick_tangente = false;
            }
        }

        private void Secante_button_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            ContadorClick_biseccion = false;
            ContadorClick_reglafalsa = false;
            ContadorClick_tangente = false;
            ContadorClick_Ecuaciones = false;

            if (ContadorClick_Secante == false)
            {
                Secante_button.Background = (Brush)bc.ConvertFrom("#FF343131");
                grid5.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Hidden;
                grid3.Visibility = Visibility.Hidden;
                grid4.Visibility = Visibility.Hidden;
                biseccion.Background = (Brush)bc.ConvertFrom("#FF232323");
                regla_falsa.Background = (Brush)bc.ConvertFrom("#FF232323");
                Tangente_button.Background = (Brush)bc.ConvertFrom("#FF232323");
                ContadorClick_Secante = true;
            }
            else
            {
                Secante_button.Background = (Brush)bc.ConvertFrom("#FF232323");
                grid5.Visibility = Visibility.Hidden;
                ContadorClick_Secante = false;
            }
        }

        private void Grey_Secante(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Secante_button.Background = (Brush)bc.ConvertFrom("#FF343131");
        }

        private void White_Secante(object sender, MouseEventArgs e)
        {
            if (ContadorClick_Secante == false)
            {
                var bc = new BrushConverter();
                Secante_button.Background = (Brush)bc.ConvertFrom("#FF232323");
            }
        }

        private void Resolver_Secante_Click(object sender, RoutedEventArgs e)
        {
            ResultadoRaizAbiertos resultado = new ResultadoRaizAbiertos(Convert.ToInt32(iteraciones_sec_textbox.Text), Convert.ToDouble(error_sec_textbox.Text));
            resultado.x0 = Convert.ToDouble(x0_sec_textbox.Text);
            resultado.x1 = Convert.ToDouble(x1_sec_textbox.Text);

            Function f = new Function("f(x) = " + fx_sec_textbox.Text);
            var Metodos = new Metodos();

            Metodos.Secante(resultado, f);

            Resultado_label_sec.Content = "Raíz: " + resultado.valorRaiz;
            ResultadoError_label_sec.Content = "Error: " + resultado.error;
            iterusadas_sec_label.Content = "Iteraciones: " + resultado.iteraciones;
            Resultado_label_tan.Visibility = Visibility.Visible;
            ResultadoError_label_tan.Visibility = Visibility.Visible;
            iterusadas_tan_label.Visibility = Visibility.Visible;
        }

        private void ecuaciones_grey(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            SistEcuac_button.Background = (Brush)bc.ConvertFrom("#FF343131");
        }

        private void ecuaciones_white(object sender, MouseEventArgs e)
        {
            if (ContadorClick_Ecuaciones == false)
            {
                var bc = new BrushConverter();
                SistEcuac_button.Background = (Brush)bc.ConvertFrom("#FF232323");
            }
        }

        private void grilla_button(object sender, RoutedEventArgs e)
        {
            ContadorClick_biseccion = false;
            ContadorClick_reglafalsa = false;
            ContadorClick_tangente = false;
            ContadorClick_Secante = false;
          
            Grilla a = new Grilla();
            a.Show();
        }

        private void click_bttn_regresion(object sender, RoutedEventArgs e)
        {
            Regresion a = new Regresion();
            a.Show();
        }
    }
}
