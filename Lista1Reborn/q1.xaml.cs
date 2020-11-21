using System;
using System.Threading;
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
    /// Logika interakcji dla klasy q1.xaml
    /// </summary>
    public partial class q1 : Window
    {
        public q1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            wynik.Text += b.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                rozwiazanie();
            }
            catch (Exception)
            {
                wynik.Text = "Błąd";
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs eventArgs) 
        {
            wynik.Text = "";
        }


        private void rozwiazanie()
        {

            //Działanie
            String abc;
            int iAbc = 0;
            if (wynik.Text.Contains("+"))
            {
                iAbc = wynik.Text.IndexOf("+");
            }
            else if (wynik.Text.Contains("-"))
            {
                iAbc = wynik.Text.IndexOf("-");
            }
            else if (wynik.Text.Contains("*"))
            {
                iAbc = wynik.Text.IndexOf("*");
            }
            else if (wynik.Text.Contains("/"))
            {
                iAbc = wynik.Text.IndexOf("/");
            }
            else
            {

            }
            abc = wynik.Text.Substring(iAbc, 1);
            double abc1 = Convert.ToDouble(wynik.Text.Substring(0, iAbc));
            double abc2 = Convert.ToDouble(wynik.Text.Substring(iAbc + 1, wynik.Text.Length - iAbc - 1));

            if (abc == "+")
            {
                wynik.Text += "=" + (abc1 + abc2);
            }
            else if (abc == "-")
            {
                wynik.Text += "=" + (abc1 - abc2);
            }
            else if (abc == "*")
            {
                wynik.Text += "=" + (abc1 * abc2);
            }
            else if (abc == "/")
            {
                wynik.Text += "=" + (abc1 / abc2);
            }

        }

    }
}
