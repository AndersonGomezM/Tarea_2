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

namespace Ejercicio4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Ejercicio 4.2
                Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.*/
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalcularButton_Click(Object sender, RoutedEventArgs e)
        {
            var num = int.Parse(NumTextBox.Text);
            var exp = int.Parse(ExponentTextBox.Text);
            var result = Math.Pow(num, exp);
            ResultTextBlock.Text = "" + result;
            
            
        }
    }
}
