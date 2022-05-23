using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Page
{
    /// <summary>
    /// Interaction logic for JegyrendelesPage.xaml
    /// </summary>
    public partial class JegyrendelesPage : Page
    {
        private readonly float KM_DIJ = 50F;
        private float kedvezmenySzorzo = 1;

        public JegyrendelesPage()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string? tag = (sender as RadioButton)?.Tag.ToString();

            if (tag != null)
                kedvezmenySzorzo = float.Parse(tag);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTavolsag.Text))
            {
                MessageBox.Show("A távolságot kötelező megadni!");
                return;
            }

            try
            {
                float tavolsag = float.Parse(tbTavolsag.Text);
                string? tag = (cbTipus.SelectedItem as ComboBoxItem)?.Tag.ToString();

                if (tag == null)
                    return;

                float tipusSzorzo = float.Parse(tag);
                float fizetendo = tavolsag * KM_DIJ * kedvezmenySzorzo * tipusSzorzo;

                MessageBox.Show($"A fizetendő: { fizetendo } HUF");
            }
            catch (FormatException)
            {
                MessageBox.Show("A megadott távolság rossz formátumú!");
            }
        }
    }
}
