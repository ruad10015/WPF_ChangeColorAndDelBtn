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

namespace WpfFirstApplication
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            byte red = (byte)random.Next(256);
            byte green = (byte)random.Next(256);
            byte blue = (byte)random.Next(256);

            SolidColorBrush randomBrush = new SolidColorBrush(Color.FromRgb(red, green, blue));
            if(sender is Button btn)
            {
                btn.Background = randomBrush;
                MessageBox.Show($"Button {btn.Content}","Information");
            }
        }

        private void btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                if (btn.Parent is StackPanel parentStackPanel)
                {
                    parentStackPanel.Children.Remove(btn);
                }
                this.Title = "Button " + btn.Content;
            }
        }
    }
}
