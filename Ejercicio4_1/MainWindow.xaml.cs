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

namespace Ejercicio4_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Ejercicio 4.1
                Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.*/
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalcularButton_Click(Object sender, RoutedEventArgs e)
        {
            TablaTextBox.Text = Tabla.Multiplicar(int.Parse(NumTextBox.Text));
        }
        
    }
}
