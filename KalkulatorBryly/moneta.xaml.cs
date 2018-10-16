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
    /// Logika interakcji dla klasy moneta.xaml
    /// </summary>
    public partial class moneta : Page
    {
        double pi;

        public moneta()
        {
            InitializeComponent();
            pi = Math.PI;
        }

        private void Bwymiary_Click(object sender, RoutedEventArgs e)
        {
            String typ = Lista.SelectedValue.ToString();
            typ = typ.Remove(0, 38);
            String t;
            double n;
            bool czy;
            switch (typ)
            {
                case ("Promień"):
                    t = Tpromien.Text;
                    czy = double.TryParse(t, out n);
                    if (czy == true)
                    {
                        n = double.Parse(t);
                        Tsrednica.Text = (n * 2).ToString();
                        Tobwod.Text = (2 * n * pi).ToString();
                        Tpowierzchnia.Text = (pi * n * n).ToString();
                    }
                    break;
                case ("Średnica"):
                    t = Tsrednica.Text;
                    czy = double.TryParse(t, out n);
                    if (czy == true)
                    {
                        n = double.Parse(t);
                        n /= 2;
                        Tpromien.Text = n.ToString();
                        Tobwod.Text = (2 * n * pi).ToString();
                        Tpowierzchnia.Text = (pi * n * n).ToString();
                    }
                    break;
                case ("Powierzchnia"):
                    t = Tpowierzchnia.Text;
                    czy = double.TryParse(t, out n);
                    if (czy == true)
                    {
                        n = double.Parse(t);
                        n /= pi;
                        n = Math.Sqrt(n);
                        Tpromien.Text = n.ToString();
                        Tsrednica.Text = (n * 2).ToString();
                        Tobwod.Text = (2 * n * pi).ToString();
                    }
                    break;
                case ("Obwód"):
                    t = Tpowierzchnia.Text;
                    czy = double.TryParse(t, out n);
                    if (czy == true)
                    {
                        n = double.Parse(t);
                        n /= pi;
                        n /= 2;
                        Tpromien.Text = n.ToString();
                        Tsrednica.Text = (n * 2).ToString();
                        Tpowierzchnia.Text = (pi * n * n).ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Bgrubosc_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double powierzchnia = 0;
            double objętosc = 0;

            t = Tpowierzchnia.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                powierzchnia = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tobjetosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                objętosc = double.Parse(t);
            }
            else
            {
                return;
            }
            Tgrubosc.Text = (objętosc / powierzchnia).ToString();
        }

        private void Bobjetosc_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double powierzchnia = 0;
            double grubosc = 0;

            t = Tpowierzchnia.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                powierzchnia = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tgrubosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                grubosc = double.Parse(t);
            }
            else
            {
                return;
            }
            Tobjetosc.Text = (grubosc * powierzchnia).ToString();
        }

        private void Bpowierzchnia_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double grubosc = 0;
            double objętosc = 0;

            t = Tgrubosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                grubosc = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tobjetosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                objętosc = double.Parse(t);
            }
            else
            {
                return;
            }
            Tpowierzchnia.Text = (objętosc / grubosc).ToString();
        }

        private void Bobjetosc2_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double masa = 0;
            double gestosc = 0;

            t = Tgestosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                gestosc = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tmasa.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                masa = double.Parse(t);
            }
            else
            {
                return;
            }
            Tobjetosc.Text = (masa / gestosc).ToString();
        }

        private void Bgestosc_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double masa = 0;
            double objetosc = 0;

            t = Tobjetosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                objetosc = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tmasa.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                masa = double.Parse(t);
            }
            else
            {
                return;
            }
            Tgestosc.Text = (masa / objetosc).ToString();
        }

        private void Bmasa_Click(object sender, RoutedEventArgs e)
        {
            String t;
            double n;
            bool czy;
            double objetosc = 0;
            double gestosc = 0;

            t = Tobjetosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                objetosc = double.Parse(t);
            }
            else
            {
                return;
            }
            t = Tgestosc.Text.ToString();
            czy = double.TryParse(t, out n);
            if (czy == true)
            {
                gestosc = double.Parse(t);
            }
            else
            {
                return;
            }
            Tmasa.Text = (gestosc * objetosc).ToString();
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

        private void Bhelp_Click(object sender, RoutedEventArgs e)
        {
            //okno pomocy
        }

        private void Bczysc_Click(object sender, RoutedEventArgs e)
        {
            Tpromien.Text = "0";
            Tsrednica.Text = "0";
            Tpowierzchnia.Text = "0";
            Tobwod.Text = "0";
            Tobjetosc.Text = "0";
            Tgrubosc.Text = "0";
            Tmasa.Text = "0";
            Tgestosc.Text = "0";
            Metale.Text = "inne";
        }

        private void Bwyjscie_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
