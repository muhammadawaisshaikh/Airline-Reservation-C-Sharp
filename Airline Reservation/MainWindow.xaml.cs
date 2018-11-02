using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Airline_Reservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SplashScreen splashScreen = new SplashScreen("splashing.png");
            splashScreen.Show(true);
            Thread.Sleep(3000);

            login l = new login();
            frame.NavigationService.Navigate(l);

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close();
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	DragMove();
        }
    }
}
