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
    /// Logika interakcji dla klasy szescian.xaml
    /// </summary>
    public partial class szescian : Page
    {
        public szescian()
        {
            InitializeComponent();
        }

        private void Blicz_Click(object sender, RoutedEventArgs e)
        {
            bool czyMozna = true;
            String text = Tbok.Text;
            double n;
            bool czy = double.TryParse(text, out n);
            if (czy == false) czyMozna = false;
            text = Tobjetosc.Text;
            czy = double.TryParse(text, out n);
            if (czy == false) czyMozna = false;
            text = Tpowierzchnia.Text;
            czy = double.TryParse(text, out n);
            if (czy == false) czyMozna = false;
            text = Tpowierzchnia2.Text;
            czy = double.TryParse(text, out n);
            if (czy == false) czyMozna = false;

            if (czyMozna == false)
            {
                //komunikat
                return;
            }

            String typ = Lista.SelectedValue.ToString();
            typ = typ.Remove(0, 38);
            String a;
            double x;
            double y;
            switch (typ)
            {
                case "Długość krawędzi":
                    a = Tbok.Text;
                    x = Convert.ToDouble(a);
                    Tpowierzchnia.Text = (x * x).ToString();
                    Tpowierzchnia2.Text = (x * x * 6).ToString();
                    Tobjetosc.Text = (x * x * x).ToString();
                    break;
                case "Powierzchnia ściany bocznej":
                    a = Tpowierzchnia.Text;
                    x = Convert.ToDouble(a);
                    Tpowierzchnia2.Text = (x * 6).ToString();
                    y = Math.Sqrt(x);
                    Tbok.Text = y.ToString();
                    Tobjetosc.Text = (y * y * y).ToString();
                    break;
                case "Powierzchnia całkowita":
                    a = Tpowierzchnia2.Text;
                    x = Convert.ToDouble(a);
                    y = x / 6;
                    Tpowierzchnia.Text = (y).ToString();
                    y = Math.Sqrt(y);
                    Tbok.Text = y.ToString();
                    Tobjetosc.Text = (y * y * y).ToString();
                    break;
                case "Objętość":
                    a = Tobjetosc.Text;
                    x = Convert.ToDouble(a);
                    y = Math.Pow(x, (double)1 / 3);
                    Tbok.Text = y.ToString();
                    Tpowierzchnia.Text = (y * y).ToString();
                    Tpowierzchnia2.Text = (y * y * 6).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Bczysc_Click(object sender, RoutedEventArgs e)
        {
            Tbok.Text = "0";
            Tpowierzchnia.Text = "0";
            Tpowierzchnia2.Text = "0";
            Tobjetosc.Text = "0";
            Tgestosc.Text = "0";
            Tmasa.Text = "0";
            Metale.Text = "inne";
        }

        private void Bgestosc_Click(object sender, RoutedEventArgs e)
        {
            String a = Tmasa.Text;
            String b = Tobjetosc.Text;

            bool czyMozna = true;
            String text = Tbok.Text;
            double n;
            bool czy = double.TryParse(a, out n);
            if (czy == false) czyMozna = false;
            czy = double.TryParse(b, out n);
            if (czy == false) czyMozna = false;

            if (czyMozna == false)
            {
                //komunikat
                return;
            }

            double masa = double.Parse(a);
            double objentosc = double.Parse(b);
            Tgestosc.Text = (masa / objentosc).ToString();
        }

        private void Bmasa_Click(object sender, RoutedEventArgs e)
        {
            String a = Tobjetosc.Text;
            String b = Tgestosc.Text;

            bool czyMozna = true;
            String text = Tbok.Text;
            double n;
            bool czy = double.TryParse(a, out n);
            if (czy == false) czyMozna = false;
            czy = double.TryParse(b, out n);
            if (czy == false) czyMozna = false;

            if (czyMozna == false)
            {
                //komunikat
                return;
            }

            double objetosc = double.Parse(a);
            double gestosc = double.Parse(b);
            Tmasa.Text = (objetosc * gestosc).ToString();
        }

        private void Metale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String metal = "";
            metal = Metale.SelectedValue.ToString();
            metal = metal.Remove(0, 38);

            switch (metal)
            {
                case "złoto":
                    Tgestosc.Text = "19,3";
                    break;
                case "srebro":
                    Tgestosc.Text = "10,49";
                    break;
                case "żelazo":
                    Tgestosc.Text = "7,874";
                    break;
                case "miedź":
                    Tgestosc.Text = "8,92";
                    break;
                case "ołów":
                    Tgestosc.Text = "11,34";
                    break;
                default:
                    Tgestosc.Text = "0";
                    break;
            }
        }

        private void Bobjetosc2_Click(object sender, RoutedEventArgs e)
        {

            String a = Tmasa.Text;
            String b = Tgestosc.Text;

            bool czyMozna = true;
            String text = Tbok.Text;
            double n;
            bool czy = double.TryParse(a, out n);
            if (czy == false) czyMozna = false;
            czy = double.TryParse(b, out n);
            if (czy == false) czyMozna = false;

            if (czyMozna == false)
            {
                //komunikat
                return;
            }

            double masa = double.Parse(a);
            double gestosc = double.Parse(b);
            Tobjetosc.Text = (masa / gestosc).ToString();

        }

        private void Bhelp_Click(object sender, RoutedEventArgs e)
        {
            //otwarcie okna pomocy
        }

        private void Bwyjscie_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
