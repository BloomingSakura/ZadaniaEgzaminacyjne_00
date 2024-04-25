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

namespace INF04
{
    /// <summary>
    /// Logika interakcji dla klasy Styczen2024.xaml
    /// </summary>
    public partial class Styczen2024 : Window
    {
        public Styczen2024()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();
           mainWindow.Show();
           this.Close();  
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(paczka.IsChecked == true)
            {
                paczka_zdj.Visibility = Visibility.Visible;
                list_zdj.Visibility = Visibility.Collapsed;
                pocztowka_zdj.Visibility = Visibility.Collapsed;
                cena.Content = "Cena: 10 zł";
            }
            else if(list.IsChecked == true)
            {
                paczka_zdj.Visibility = Visibility.Collapsed;
                list_zdj.Visibility = Visibility.Visible;
                pocztowka_zdj.Visibility = Visibility.Collapsed;
                cena.Content = "Cena: 1.5 zł";
            }
            else
            {
                paczka_zdj.Visibility = Visibility.Collapsed;
                list_zdj.Visibility = Visibility.Collapsed;
                pocztowka_zdj.Visibility = Visibility.Visible;
                cena.Content = "Cena: 1 zł";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int kod;
            bool prawidlowy_kod = int.TryParse(kod_pocztowy.Text, out kod);
             if(prawidlowy_kod == true)
             {
                if(kod_pocztowy.Text.Length == 5)
                {
                    MessageBox.Show($" Dane adresowe: {ulica.Text}, {miasto.Text}, {kod}");
                }
                else
                {
                    MessageBox.Show("Kod pocztowy powinien składać się z 5 cyfr");
                }
             }
            else
            {
                MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
            }

        }
    }
}
