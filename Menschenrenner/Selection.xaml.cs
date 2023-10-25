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

namespace Menschenrenner
{
    /// <summary>
    /// Interaktionslogik für Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ben_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ben_text.Visibility = Visibility.Visible;
            damian_img.Visibility = Visibility.Hidden;
            jan_img.Visibility = Visibility.Hidden;
            janick_img.Visibility = Visibility.Hidden;
            joel_img.Visibility = Visibility.Hidden;
            ben_choose.Visibility = Visibility.Visible;
        }
        private void ben_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {           
            ben_text.Visibility = Visibility.Hidden;
            damian_img.Visibility = Visibility.Visible;
            jan_img.Visibility = Visibility.Visible;
            janick_img.Visibility = Visibility.Visible;
            joel_img.Visibility = Visibility.Visible;
            
        }
        private void damian_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            damian_text.Visibility = Visibility.Visible;
            ben_img.Visibility = Visibility.Hidden;
            jan_img.Visibility = Visibility.Hidden;
            janick_img.Visibility = Visibility.Hidden;
            joel_img.Visibility = Visibility.Hidden;
            damian_choose.Visibility = Visibility.Visible;
        }
        private void damian_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            damian_text.Visibility = Visibility.Hidden;
            ben_img.Visibility = Visibility.Visible;
            jan_img.Visibility = Visibility.Visible;
            janick_img.Visibility = Visibility.Visible;
            joel_img.Visibility = Visibility.Visible;
        }
        private void jan_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            jan_text.Visibility = Visibility.Visible;
            ben_img.Visibility = Visibility.Hidden;
            damian_img.Visibility = Visibility.Hidden;
            janick_img.Visibility = Visibility.Hidden;
            joel_img.Visibility = Visibility.Hidden;
            jan_choose.Visibility = Visibility.Visible;
        }
        private void jan_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            jan_text.Visibility = Visibility.Hidden;
            ben_img.Visibility = Visibility.Visible;
            damian_img.Visibility = Visibility.Visible;
            janick_img.Visibility = Visibility.Visible;
            joel_img.Visibility = Visibility.Visible;
        }
        private void janick_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            janick_text.Visibility = Visibility.Visible;
            ben_img.Visibility = Visibility.Hidden;
            damian_img.Visibility = Visibility.Hidden;
            jan_img.Visibility = Visibility.Hidden;
            joel_img.Visibility = Visibility.Hidden;
            janick_choose.Visibility = Visibility.Visible;
        }
        private void janick_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            janick_text.Visibility = Visibility.Hidden;
            ben_img.Visibility = Visibility.Visible;
            damian_img.Visibility = Visibility.Visible;
            jan_img.Visibility = Visibility.Visible;
            joel_img.Visibility = Visibility.Visible;
        }
        private void joel_Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            joel_text.Visibility = Visibility.Visible;
            ben_img.Visibility = Visibility.Hidden;
            damian_img.Visibility = Visibility.Hidden;
            jan_img.Visibility = Visibility.Hidden;
            janick_img.Visibility = Visibility.Hidden;
            joel_choose.Visibility = Visibility.Visible;
        }
        private void joel_Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            joel_text.Visibility = Visibility.Hidden;
            ben_img.Visibility = Visibility.Visible;
            damian_img.Visibility = Visibility.Visible;
            jan_img.Visibility = Visibility.Visible;
            janick_img.Visibility = Visibility.Visible;
        }
        private void damian_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
           

        }
        private void ben_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        private void jan_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        private void janick_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void joel_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


    }
}
