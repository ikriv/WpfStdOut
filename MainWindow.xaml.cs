using System;
using System.Windows;

namespace WpfStdOut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OutputTextBox.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var line = OutputTextBox.Text;
            Console.Out.WriteLine(line);
        }
    }
}
