using DotLiquid.Util;
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
using System.Drawing;

namespace traffic_lights
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


        private void Button_Start(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = "Пуск";
            mainLabel.Background = new SolidColorBrush(Colors.Green);   
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = "Останов";
            mainLabel.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Whait(object sender, RoutedEventArgs e)
        {
            mainLabel.Content = "В ожидании";
            mainLabel.Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
