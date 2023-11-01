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
using System.Windows.Threading;

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
            Random random = new Random();
            int benRandom = random.Next(1, 101); 
            int janickRandom = random.Next(1, 7);
            int janRandom = random.Next(1, 5);
            int damianRandom = random.Next(1, 9);

            StartJoëlAnimation();
            if (benRandom < 80)
            {
                if(damianRandom == 1)
                {
                    DispatcherTimer damiantimer = new DispatcherTimer();
                    damiantimer.Tick += (sender, e) =>
                    {
                        damiantimer.Stop(); 
                        StartDamianAnimation();

                    };
                    damiantimer.Interval = TimeSpan.FromSeconds(1);
                    damiantimer.Start();
                }
                else
                {
                    StartDamianAnimation();
                }

                if(janickRandom == 1)
                {
                    DispatcherTimer janicktimer = new DispatcherTimer();
                    janicktimer.Tick += (sender, e) =>
                    {
                        janicktimer.Stop(); 
                        StartJanickAnimation(); 

                    };
                    janicktimer.Interval = TimeSpan.FromSeconds(3);
                    janicktimer.Start();
                }
                else
                {
                    StartJanickAnimation();
                }
                if (janRandom == 1)
                {
                    DispatcherTimer jantimer = new DispatcherTimer();
                    jantimer.Tick += (sender, e) =>
                    {
                        jantimer.Stop();
                        StartJanAnimation();

                    };
                    jantimer.Interval = TimeSpan.FromSeconds(3);
                    jantimer.Start();
                }
                else
                {
                    StartJanAnimation();
                }

                DispatcherTimer timer = new DispatcherTimer();
                timer.Tick += (sender, e) =>
                {
                    timer.Stop(); // Stoppt den Timer nach 2 Sekunden
                    StartBenAnimation(); // Startet die Ben-Animation

                };
                timer.Interval = TimeSpan.FromSeconds(5);
                timer.Start();
            }
            else
            {
                StartBenAnimation();
                StartJanickAnimation();
                StartJanAnimation();
                StartDamianAnimation();
            }
        }

        private void StartJoëlAnimation()
        {
            joëlanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - joël_img.Width,
                Duration = TimeSpan.FromSeconds(9)
            };
            joëlanimation.Completed += joëlgewinner;
            joël_img.BeginAnimation(Canvas.LeftProperty, joëlanimation);
        }

        private void StartBenAnimation()
        {
            benanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - Ben_img.Width,
                Duration = TimeSpan.FromSeconds(5)
            };
            benanimation.Completed += bengewinner;
            Ben_img.BeginAnimation(Canvas.LeftProperty, benanimation);
        }

        private void StartJanickAnimation()
        {
            // Janick's Animation starten
            janickanimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - janick_img.Width,
                Duration = TimeSpan.FromSeconds(6)
            };
            janickanimation.Completed += janickgewinner;
            janick_img.BeginAnimation(Canvas.LeftProperty, janickanimation);
        }

        private void StartJanAnimation()
        {
            // Jan's Animation starten
            jananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - jan_img.Width,
                Duration = TimeSpan.FromSeconds(7)
            };
            jananimation.Completed += jangewinner;
            jan_img.BeginAnimation(Canvas.LeftProperty, jananimation);
        }

        private void StartDamianAnimation()
        {
            // Damian's Animation starten
            damiananimation = new DoubleAnimation
            {
                From = 10,
                To = RaceTrack.ActualWidth - damian_img.Width,
                Duration = TimeSpan.FromSeconds(8)
            };
            damiananimation.Completed += damiangewinner;
            damian_img.BeginAnimation(Canvas.LeftProperty, damiananimation);
        }
        private void jangewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Jan ist der Gewinner");
                gewinner = 1;
                figurenreset();
            }
        }
        private void joëlgewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Joël ist der Gewinner");
                gewinner = 1;
                figurenreset();
            }
        }
        private void damiangewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Damian ist der Gewinner");
                gewinner = 1;
                figurenreset();
            }
        }
        private void bengewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Ben ist der Gewinner");
                gewinner = 1;
                figurenreset();
            }

        }
        private void janickgewinner(object sender, EventArgs e)
        {

            if (gewinner == 0)
            {
                MessageBox.Show("Janick ist der Gewinner");
                gewinner = 1;
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

            Canvas.SetLeft(Ben_img, originalBenPosition);
            Canvas.SetLeft(damian_img, originalDamianPosition);
            Canvas.SetLeft(jan_img, originalJanPosition);
            Canvas.SetLeft(janick_img, originalJanickPosition);
            Canvas.SetLeft(joël_img, originalJoëlPosition);
            this.Hide();

            Selection selection = new Selection();
            selection.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Startrennen();
        }
    }
}
