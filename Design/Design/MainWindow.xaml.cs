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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Design
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            DoubleAnimation animation = new DoubleAnimation();
            animation.AutoReverse = true;
           // animation.Duration = TimeSpan.FromDays(365);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.From = elipse.Width;
            animation.To = 500;
            elipse.BeginAnimation(Ellipse.WidthProperty, animation);
            */
        }


        /*
        private void Rectangle_MouseEnter(object sender, MouseEventArgs aa)
        {
            rectangle.Fill = Brushes.Red;
            rectangle.Fill = Brushes.Yellow;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs aa)
        {
            rectangle.Fill = Brushes.AliceBlue;
            rectangle.Fill = Brushes.Green;
        }
        */
    }
}
