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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        int a = 0;
        string znak = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            pole.Text = pole.Text + btn.Content.ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(pole.Text);
            znak = "+";
            pole.Text = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(pole.Text);
            znak = "-";
            pole.Text = "";
        }

        private void umnoj_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(pole.Text);
            znak = "*";
            pole.Text = "";
        }

        private void delenie_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(pole.Text);
            znak = "/";
            pole.Text = "";
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            int b = Convert.ToInt32(pole.Text);

            if (znak == "+")
                pole.Text = (a + b).ToString();
            if (znak == "-")
                pole.Text = (a - b).ToString();
            if (znak == "*")
                pole.Text = (a * b).ToString();
            if (znak == "/")
                pole.Text = (a / b).ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            pole.Text = "";
            a = 0;
            znak = "";
        }
    }
}