using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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

namespace Menschenrenner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Startrennen()
        {

            DoubleAnimation benanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - Ben_img.Width,
                Duration = TimeSpan.FromSeconds(10)
            };
            DoubleAnimation damiananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - damian_img.Width,
                Duration = TimeSpan.FromSeconds(10)
            };
            DoubleAnimation jananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - jan_img.Width,
                Duration = TimeSpan.FromSeconds(10)
            };
            DoubleAnimation janickanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - janick_img.Width,
                Duration = TimeSpan.FromSeconds(10)
            };
            DoubleAnimation joëlanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - joël_img.Width,
                Duration = TimeSpan.FromSeconds(10)
            };
            Ben_img.BeginAnimation(Canvas.LeftProperty, benanimation);
            damian_img.BeginAnimation(Canvas.LeftProperty, damiananimation);
            jan_img.BeginAnimation(Canvas.LeftProperty, jananimation);
            janick_img.BeginAnimation(Canvas.LeftProperty, janickanimation);
            joël_img.BeginAnimation(Canvas.LeftProperty, joëlanimation);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Startrennen();

        }
    }
}
