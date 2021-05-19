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

namespace zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstNumber;
        int secondNumber;
        int total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateAdd(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(numA.Text);
            secondNumber = Convert.ToInt32(numB.Text);

            total = firstNumber + secondNumber;

            result.Content = "Suma " + numA.Text + " + " + numB.Text + " = " + total.ToString();
        }

        private void CalculateSubtract(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(numA.Text);
            secondNumber = Convert.ToInt32(numB.Text);

            total = firstNumber - secondNumber;

            result.Content = "Suma " + numA.Text + " - " + numB.Text + " = " + total.ToString();
        }

        private void CalculateMultiply(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(numA.Text);
            secondNumber = Convert.ToInt32(numB.Text);

            total = firstNumber * secondNumber;

            result.Content = "Suma " + numA.Text + " * " + numB.Text + " = " + total.ToString();
        }

        private void CalculateDivide(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(numA.Text);
            secondNumber = Convert.ToInt32(numB.Text);

            if(firstNumber != 0 && secondNumber != 0)
            {

            total = firstNumber + secondNumber;

            result.Content = "Suma " + numA.Text + " / " + numB.Text + " = " + total.ToString();

            } else
            {
                result.Content = "Nie mozna dzielic przez 0 !";
                MessageBox.Show("Nie mozna dzielic przez 0 !");
            }
        }
    }
}
