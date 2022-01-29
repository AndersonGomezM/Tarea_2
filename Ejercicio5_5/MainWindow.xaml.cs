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

namespace Ejercicio5_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Ejercicio 5.5
                Hacer una función que dado un número nos regrese
                una cadena donde se encuentre escrito en palabras.*/
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AceptarButton_Click(Object sender, RoutedEventArgs e)
        {
            if(int.Parse(NumTextBox.Text) >= 0 && int.Parse(NumTextBox.Text) <= 10)
                ResultTextBlock.Text = Cadena.Numeros(int.Parse(NumTextBox.Text));
            else
                MessageBox.Show("Erro al insartar el digito.");
        }
    }
}
