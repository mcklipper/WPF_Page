using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Page
{
    /// <summary>
    /// Interaction logic for Homerseklet.xaml
    /// </summary>
    public partial class HomersekletPage : Page
    {
        public HomersekletPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbHomerseklet.Text))
            {
                MessageBox.Show("A Hőmérsékletet ki kell tölteni!");
                return;
            }

            try
            {
                float celsius = float.Parse(tbHomerseklet.Text);
                float kelvin = celsius + 273.15F;
                float fahrenheit = celsius * 9 / 5 + 32;

                lblKelvin.Content = $"A megadott hőmérséklet kelvinben: { kelvin }";
                lblFahrenheit.Content = $"A megadott hőmérséklet fahrenheitben: { fahrenheit }";
            }
            catch (FormatException)
            {
                MessageBox.Show("Nem megfelelő a beírt szám formátuma!");
            }
        }
    }
}
