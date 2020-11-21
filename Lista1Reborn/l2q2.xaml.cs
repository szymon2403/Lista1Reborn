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

namespace Lista1Reborn
{
    /// <summary>
    /// Logika interakcji dla klasy l2q2.xaml
    /// </summary>
    public partial class l2q2 : Window
    {
        public l2q2()
        {
            InitializeComponent();
            resetgame();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reset Button");
            resetgame();

        }

        private void resetgame() 
        {
            c1.Content = null;
            c2.Content = null;
            c3.Content = null;
            c4.Content = null;
            c5.Content = null;
            c6.Content = null;
            c7.Content = null;
            c8.Content = null;
            c9.Content = null;
            c2.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c3.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c4.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c5.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c6.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c7.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c8.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c9.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
            c1.Background = new SolidColorBrush(Color.FromRgb(50, 50, 50));
        }
        private void playerClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Content = "X";
            btn.Background = Brushes.Red;
            btn.IsEnabled = false;

            checking();
            AI();
        }
        private void AI() 
        {

            checking();
        }

        private void checking()
        {
            if (
                c1.Background == Brushes.Green && c2.Background == Brushes.Green && c3.Background == Brushes.Green
                || c1.Background == Brushes.Green && c5.Background == Brushes.Green && c9.Background == Brushes.Green
                || c1.Background == Brushes.Green && c4.Background == Brushes.Green && c7.Background == Brushes.Green
                || c2.Background == Brushes.Green && c5.Background == Brushes.Green && c8.Background == Brushes.Green
                || c3.Background == Brushes.Green && c6.Background == Brushes.Green && c9.Background == Brushes.Green
                || c3.Background == Brushes.Green && c5.Background == Brushes.Green && c7.Background == Brushes.Green
                || c4.Background == Brushes.Green && c5.Background == Brushes.Green && c8.Background == Brushes.Green
                || c7.Background == Brushes.Green && c8.Background == Brushes.Green && c9.Background == Brushes.Green
                )
            /*if (c1.Content == "X" && c2.Content == "X" && c3.Content == "X"
               || c1.Content == "X" && c4.Content == "X" && c7.Content == "X"
               || c1.Content == "X" && c5.Content == "X" && c9.Content == "X"
               || c2.Content == "X" && c5.Content == "X" && c8.Content == "X"
               || c3.Content == "X" && c6.Content == "X" && c9.Content == "X"
               || c3.Content == "X" && c5.Content == "X" && c7.Content == "X"
               || c4.Content == "X" && c5.Content == "X" && c6.Content == "X"
               || c7.Content == "X" && c8.Content == "X" && c9.Content == "X")*/
            {
                MessageBox.Show("U Won");
                resetgame();
            }
            else if (
                    c1.Background == Brushes.Red && c2.Background == Brushes.Red && c3.Background == Brushes.Red
                || c1.Background == Brushes.Red && c5.Background == Brushes.Red && c9.Background == Brushes.Red
                || c1.Background == Brushes.Red && c4.Background == Brushes.Red && c7.Background == Brushes.Red
                || c2.Background == Brushes.Red && c5.Background == Brushes.Red && c8.Background == Brushes.Red
                || c3.Background == Brushes.Red && c6.Background == Brushes.Red && c9.Background == Brushes.Red
                || c3.Background == Brushes.Red && c5.Background == Brushes.Red && c7.Background == Brushes.Red
                || c4.Background == Brushes.Red && c5.Background == Brushes.Red && c8.Background == Brushes.Red
                || c7.Background == Brushes.Red && c8.Background == Brushes.Red && c9.Background == Brushes.Red
                )
            {
                MessageBox.Show("U lost :(");
                resetgame();
            }
        }
    }
}
