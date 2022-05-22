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

namespace CW_05222022_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var animation = new System.Windows.Media.Animation.DoubleAnimation();
            animation.To = 100;
            animation.From = 250;
            animation.Duration = TimeSpan.FromMilliseconds(5000);
            button.BeginAnimation(Button.WidthProperty, animation);
        }

        private void Picture_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            var animation = new System.Windows.Media.Animation.DoubleAnimation();
            animation.To = 250;
            animation.From = 80;
            animation.Duration = TimeSpan.FromMilliseconds(5000);
            picture.BeginAnimation(Image.WidthProperty, animation);
            picture.BeginAnimation(Image.HeightProperty, animation);
        }
    }
}
