using System;
using System.Windows;
using AreaCalculation;

namespace ClientCalculation
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbResult.IsReadOnly = true;
            tbSideX.IsEnabled = false;
            tbSideY.IsEnabled = false;
            tbSideZ.IsEnabled = false;
            tbRadius.IsEnabled = false;
        }

        private void rbCircle_Checked(object sender, RoutedEventArgs e)
        {
            if (rbCircle.IsChecked == true)
            {
                tbSideX.IsEnabled = false;
                tbSideX.Text = string.Empty;
                tbSideY.IsEnabled = false;
                tbSideY.Text = string.Empty;
                tbSideZ.IsEnabled = false;
                tbSideZ.Text = string.Empty;
                tbRadius.IsEnabled = true;
                lResult.Content = string.Empty;
                tbResult.Text = string.Empty;
            }
        }

        private void rbTriangle_Checked(object sender, RoutedEventArgs e)
        {
            if (rbTriangle.IsChecked == true)
            {
                tbSideX.IsEnabled = true;
                tbSideY.IsEnabled = true;
                tbSideZ.IsEnabled = true;
                tbRadius.IsEnabled = false;
                tbRadius.Text = string.Empty;
                lResult.Content = string.Empty;
                tbResult.Text = string.Empty;
            }
        }

        // делает расчет в зависимости от того какой RadioButton выбран
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rbCircle.IsChecked == true)
            {
                if (tbRadius.Text != String.Empty)
                {
                    Circle circle = new Circle(double.Parse(tbRadius.Text));
                    tbResult.Text = circle.Calculation()[0];
                    lResult.Content = "Площадь Круга";
                }
                else
                {
                    tbResult.Text = "0";
                    lResult.Content = "Площадь Круга";
                }
            }
            else if (rbTriangle.IsChecked == true)
            {
                if (tbSideX.Text != String.Empty || tbSideY.Text != String.Empty || tbSideZ.Text != String.Empty)
                {
                    Triangle triangle = new Triangle(double.Parse(tbSideX.Text), double.Parse(tbSideY.Text), double.Parse(tbSideZ.Text));
                    tbResult.Text = triangle.Calculation()[0];
                    lResult.Content = triangle.Calculation()[1];
                }
                else
                {
                    tbResult.Text = "0";
                    lResult.Content = "Площадь Треугольника";
                }
            }
        }
    }
}
