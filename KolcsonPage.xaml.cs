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

namespace WPF_Page
{
    /// <summary>
    /// Interaction logic for KolcsonPage.xaml
    /// </summary>
    public partial class KolcsonPage : Page
    {
        private readonly float KAMAT = 1.0125F;
        private readonly float KEZELESI_KOLTSEG = 1.25F;

        public KolcsonPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOsszeg.Text))
            {
                MessageBox.Show("Nem adott meg felvett összeget!");
                return;
            }

            try
            {
                int osszeg = int.Parse(tbOsszeg.Text);
                int futamido;

                if (rd12.IsChecked != null && (bool) rd12.IsChecked) 
                    futamido = 12;
                else if (rd24.IsChecked != null && (bool) rd24.IsChecked) 
                    futamido = 24;
                else if (rd36.IsChecked != null && (bool) rd36.IsChecked) 
                    futamido = 36;
                else 
                { 
                    MessageBox.Show("Kötelező kiválasztani a futamidőt!"); 
                    return; 
                }

                float reszlet = (float) (osszeg * KAMAT * KEZELESI_KOLTSEG) / futamido;

                MessageBox.Show($"A fizetendő havi részlet: { reszlet }");
            }
            catch (FormatException)
            {
                MessageBox.Show("A felvett összegnek megadott szám nem megfelelő formátumú!");
            }
        }
    }
}
