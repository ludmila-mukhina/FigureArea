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

namespace SquareFigure
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RBTreagle_Checked(object sender, RoutedEventArgs e)  // выбран треугольник
        {
            CBTreagle.Visibility = Visibility.Visible;
            CBParal.Visibility = Visibility.Collapsed;
            CBTreagle.IsEnabled = true;

        }

        private void RBParal_Checked(object sender, RoutedEventArgs e)  // выбран параллелограмм
        {
            CBTreagle.Visibility = Visibility.Collapsed;
            CBParal.Visibility = Visibility.Visible;
            CBParal.IsEnabled = true;
        }

        private void CBTreagle_SelectionChanged(object sender, SelectionChangedEventArgs e)  // выбор определенного способо подсчета площади треугольника
        {
            switch(CBTreagle.SelectedIndex)  // CBTreagle.SelectedIndex - индекс выбранного элемента списка
            {
                case 0:
                    TBlResult.Text = "";
                    squareTreagleParamAH.Visibility = Visibility.Visible;
                    squareTreagleParamABA.Visibility = Visibility.Collapsed;
                    squareTreagleABC.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    TBlResult.Text = "";
                    squareTreagleParamABA.Visibility = Visibility.Visible;
                    squareTreagleABC.Visibility = Visibility.Collapsed;
                    squareTreagleParamAH.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    TBlResult.Text = "";
                    squareTreagleABC.Visibility = Visibility.Visible;
                    squareTreagleParamABA.Visibility = Visibility.Collapsed;
                    squareTreagleParamAH.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)  // событие для кнопки рассчета площади
        {
            try
            {
                if (RBTreagle.IsChecked == true)
                {
                    switch (CBTreagle.SelectedIndex)
                    {
                        case 0:
                            double squareTreagle0 = Convert.ToDouble(TBBaseTreagleParal.Text) * Convert.ToDouble(TBHeightTreagleParal.Text) / 2;
                            TBlResult.Text = squareTreagle0 + "";
                            break;
                        case 1:
                            double AngleRadian = Convert.ToDouble(TBAngleTreagleParal.Text) * Math.PI / 180;
                            double squareTreagle1 = Convert.ToDouble(TBOneTreagleParal.Text) * Convert.ToDouble(TBTwoTreagleParal.Text) * Math.Sin(AngleRadian) / 2;
                            TBlResult.Text = squareTreagle1 + "";
                            break;
                        case 2:
                            // нормально все
                            break;
                    }
                }
                if (RBParal.IsChecked == true)
                {
                    switch (CBParal.SelectedIndex)
                    {
                        case 0:
                            double squareTreagle0 = Convert.ToDouble(TBBaseTreagleParal.Text) * Convert.ToDouble(TBHeightTreagleParal.Text);
                            TBlResult.Text = squareTreagle0 + "";
                            break;
                        case 1:
                            double AngleRadian = Convert.ToDouble(TBAngleTreagleParal.Text) * Math.PI / 180;
                            double squareTreagle1 = Convert.ToDouble(TBOneTreagleParal.Text) * Convert.ToDouble(TBTwoTreagleParal.Text) * Math.Sin(AngleRadian);
                            TBlResult.Text = squareTreagle1 + "";
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
        }
    }
}
