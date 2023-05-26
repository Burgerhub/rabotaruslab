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
using System.Windows.Shapes;

namespace ruslanprackt1var10
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double A1 = double.Parse(vod.Text);
            double B1 = double.Parse(vod1.Text);
            double C1 = double.Parse(vod2.Text);
            double A2 = double.Parse(vod3.Text);
            double B2 = double.Parse(vod4.Text);
            double C2 = double.Parse(vod5.Text);

            double D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;

            otv.Text = $"X={x} \n Y={y} ";
            

        }
    }
}
