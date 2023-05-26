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

namespace ruslanprackt1var10
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

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(vod.Text);
            double b = double.Parse(vod1.Text);

            double sum = Math.Abs(a) + Math.Abs(b);
            double difference = Math.Abs(a) - Math.Abs(b);
            double product = Math.Abs(a) * Math.Abs(b);
            double quotient = Math.Abs(a) / Math.Abs(b);

            otv.Text=$"Сумма модулей: {sum}";
            otv.Text=$"Разность модулей: {difference}";
            otv.Text=$"Произведение модулей: {product}";
            otv.Text=$"Частное модулей:{quotient}";
        }
    }
}
