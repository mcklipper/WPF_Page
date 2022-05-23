using System.Windows;

namespace WPF_Page
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmMain.Content = new HomersekletPage();
        }

        private void BtnHomerseklet_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new HomersekletPage();
        }

        private void BtnTorleszto_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new KolcsonPage();
        }

        private void BtnJegyrendeles_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new JegyrendelesPage();
        }
    }
}
