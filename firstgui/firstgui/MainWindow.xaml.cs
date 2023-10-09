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

namespace firstgui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            double income = Convert.ToDouble(txtincome.Text);
            double expenditure = Convert.ToDouble(txtexpenditure.Text);
            double price = Convert.ToDouble(txtprice.Text);
            double result = price / (income - expenditure);
            txtday.Text = result.ToString();
            
        }
    }
}
