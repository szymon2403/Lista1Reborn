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

namespace Lista1Reborn
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            q1 zadanie1 = new q1();
            zadanie1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            q2 zadanie2 = new q2();
            zadanie2.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            q3 zadanie3 = new q3();
            zadanie3.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            q4 zadanie4 = new q4();
            zadanie4.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void L2Button_Click_1(object sender, RoutedEventArgs e) 
        {
            l2q2 l2q2 = new l2q2();
            l2q2.Show();
            this.Hide();
        }
    }
}
