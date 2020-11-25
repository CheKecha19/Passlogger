using System.Windows;

namespace Passlogger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void bSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bHelp_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}

