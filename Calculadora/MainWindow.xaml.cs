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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double OperandoA = 0;
        public double OperandoB = 0;
        public string operacion = "";
        
        public MainWindow()
        {
            InitializeComponent();

            

        }
        
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            eventoBoton("7");
            
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            eventoBoton("8");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            eventoBoton("9");
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            eventoBoton("4");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            eventoBoton("5");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            eventoBoton("6");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            eventoBoton("1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            eventoBoton("2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            eventoBoton("3");
        }
        private void Button_Click_(object sender, RoutedEventArgs e)
        {
            eventoBoton(".");
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            eventoBoton("0");

        }
        public void eventoBoton(string valor)
        {
            if (screenResultado.Text == "0")
            {
                screenResultado.Text = "";
                screenResultado.Text += valor;
            }
            else if (screenResultado.Text.Contains(".") && valor == ".") return;
            else screenResultado.Text += valor;
        }

        public void getOperacion(string oper)
        {
            if (screenResultado.Text == "0") return;
            else
            {
                if (screenResultado.Text == "") return;
                else
                {
                    this.operacion = oper;
                    this.OperandoA = Convert.ToDouble(screenResultado.Text);
                    screenResultado.Text = "";
                }
                
            }
            
        }

        private void Button_Click_Suma(object sender, RoutedEventArgs e)
        {
            getOperacion("+");
        }

        private void Button_Click_Resta(object sender, RoutedEventArgs e)
        {
            getOperacion("-");
        }

        private void Button_Click_Multi(object sender, RoutedEventArgs e)
        {
            getOperacion("x");
        }

        private void Button_Click_Divi(object sender, RoutedEventArgs e)
        {
            getOperacion("/");
        }


        public void Resultado()
        {
            this.OperandoB = Convert.ToDouble(screenResultado.Text);
            double result;

            switch (operacion)
            {
                case "+":
                    result = OperandoA + OperandoB;
                    screenResultado.Text = result.ToString();
                    break;
                case "-":
                    result = OperandoA - OperandoB;
                    screenResultado.Text = result.ToString();
                    break;
                case "x":
                    result = OperandoA * OperandoB;
                    screenResultado.Text = result.ToString();
                    break;
                case "/":
                    result = OperandoA / OperandoB;
                    screenResultado.Text = result.ToString();
                    break;
            }
        }


        private void Button_Click_Igual(object sender, RoutedEventArgs e)
        {
            Resultado();
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            screenResultado.Text = "0";
            operacion = "";
            OperandoA = 0;
            OperandoB = 0;
        }
        //hola
    }
}
