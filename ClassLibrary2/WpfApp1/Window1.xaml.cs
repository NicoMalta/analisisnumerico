using ClassLibrary2;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoRaiz resultado = new ResultadoRaiz(Convert.ToInt32(Iteraciones.Text), Convert.ToInt32(Error.Text));
            resultado.XI = Convert.ToInt32(XD.Text);
            resultado.XD = Convert.ToInt32(XI.Text);

            var Metodos = new Metodos();

            Metodos.Biseccion(resultado);

            Resultado.Content = Convert.ToString(resultado.valorRaiz);
        }
    }
}
