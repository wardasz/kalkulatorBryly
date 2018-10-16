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

namespace KalkulatorBryly
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        szescian kostka;
        moneta mona;
        start st;

        public MainWindow()
        {
            InitializeComponent();
            kostka = new szescian();
            mona = new moneta();
            st = new start();
            Ramka.Content = st;
        }

        private void Bszescian_Click(object sender, RoutedEventArgs e)
        {
            Ramka.Content = kostka;
        }

        private void Bmoneta_Click_1(object sender, RoutedEventArgs e)
        {
            Ramka.Content = mona;
        }
    }
}
