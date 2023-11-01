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

        private DoubleAnimation benanimation;
        private DoubleAnimation damiananimation;
        private DoubleAnimation jananimation;
        private DoubleAnimation janickanimation;
        private DoubleAnimation joëlanimation;

        private int gewinner = 0;
        private double originalBenPosition;
        private double originalDamianPosition;
        private double originalJanPosition;
        private double originalJanickPosition;
        private double originalJoëlPosition;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void Startrennen()
        {

            benanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - Ben_img.Width,
                Duration = TimeSpan.FromSeconds(1)
            };
            damiananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - damian_img.Width,
                Duration = TimeSpan.FromSeconds(20)
            };
            jananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - jan_img.Width,
                Duration = TimeSpan.FromSeconds(20)
            };
            janickanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - janick_img.Width,
                Duration = TimeSpan.FromSeconds(20)
            };
            joëlanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - joël_img.Width,
                Duration = TimeSpan.FromSeconds(20)
            };

            benanimation.Completed += bengewinner;
            Ben_img.BeginAnimation(Canvas.LeftProperty, benanimation);

            damiananimation.Completed += damiangewinner;
            damian_img.BeginAnimation(Canvas.LeftProperty, damiananimation);

            jananimation.Completed += jangewinner;
            jan_img.BeginAnimation(Canvas.LeftProperty, jananimation);

            janickanimation.Completed += janickgewinner;
            janick_img.BeginAnimation(Canvas.LeftProperty, janickanimation);

            joëlanimation.Completed += joëlgewinner;
            joël_img.BeginAnimation(Canvas.LeftProperty, joëlanimation);
        }


        private void jangewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Jan ist der Gewinner");
                gewinner++;
            }
            if (gewinner > 0)
            {
                figurenreset();


            }
        }
        private void joëlgewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Joël ist der Gewinner");
                gewinner++;

            }
            if (gewinner > 0)
            {
                figurenreset();
            }
        }
        private void damiangewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Damian ist der Gewinner");
                gewinner++;

            }
            if (gewinner > 0)
            {
                figurenreset();
            }
        }
        private void bengewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Ben ist der Gewinner");
                gewinner++;

            }
            if (gewinner > 0)
            {
                figurenreset();
            }
        }
        private void janickgewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Janick ist der Gewinner");
                gewinner++;
            }
            if (gewinner > 0)
            {
                figurenreset();
            }
        }
        private void figurenreset()
        {
            Ben_img.BeginAnimation(Canvas.LeftProperty, null);
            damian_img.BeginAnimation(Canvas.LeftProperty, null);
            jan_img.BeginAnimation(Canvas.LeftProperty, null);
            janick_img.BeginAnimation(Canvas.LeftProperty, null);
            joël_img.BeginAnimation(Canvas.LeftProperty, null);

            MessageBox.Show("renne fertig");
            Canvas.SetLeft(Ben_img, originalBenPosition);
            Canvas.SetLeft(damian_img, originalDamianPosition);
            Canvas.SetLeft(jan_img, originalJanPosition);
            Canvas.SetLeft(janick_img, originalJanickPosition);
            Canvas.SetLeft(joël_img, originalJoëlPosition);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Startrennen();

        }
    }
}
