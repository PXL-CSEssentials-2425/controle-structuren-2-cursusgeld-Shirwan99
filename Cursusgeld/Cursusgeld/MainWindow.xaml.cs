using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cursusgeld
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

        private void nummerikButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(yearTextBox.Text, out double jaar))
            {
             jaarTextBlock.Text = $"Is Numeriek";
            }
            else
            {
             jaarTextBlock.Text = $"Geef een correct jaartal!";
            }      
        }

        private void colculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(yearTextBox.Text, out double jaar) && double.TryParse(urenTextBox.Text, out double hour))
            {
                double uurGeld = 1.5;
                double totalGeld = hour * uurGeld;
                if ((jaar % 4 == 0) || (jaar % 400 == 0))
                {
                    totalGeld += uurGeld;
                    resultTextBlock.Text = $"Is een schrikkeljaar";
                    inschrijvingTextBox.Text = totalGeld.ToString();
                }
                else
                {
                    resultTextBlock.Text = $"Is geen schrikkeljaar";
                }
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}