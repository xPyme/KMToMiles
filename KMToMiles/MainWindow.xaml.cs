using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMToMiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConvertButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ConvertButton.Content = "Mouse Entered";
        }

        private void ConvertButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ConvertButton.Content = "Mouse Left";
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            var input = KmToMilesLabel.Text;

            var result = double.Parse(input) * 0.6;

            ResultButton.Text = result.ToString();
            
        }
    }
}