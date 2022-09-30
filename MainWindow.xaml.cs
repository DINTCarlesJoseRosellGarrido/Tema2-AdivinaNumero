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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int valor;
        public MainWindow()
        {
            InitializeComponent();
            valor = rnd.Next(100+1);
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(numeroTextBox.Text) == valor)
            {
                resultadoTextBlock.Text = "Acertaste";
            }
            else if(int.Parse(numeroTextBox.Text) < valor)
            {
                resultadoTextBlock.Text = "Te quedas corto";
            }
            else if(int.Parse(numeroTextBox.Text) > valor)
            {
                resultadoTextBlock.Text = "Te has pasado";
            }
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text = "";
            valor = rnd.Next(100 + 1);
            numeroTextBox.Text = "";
        }
    }
}
