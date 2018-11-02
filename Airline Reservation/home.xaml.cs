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

namespace Airline_Reservation
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
        }

        private void reservationbutton_MouseEnter(object sender, MouseEventArgs e)
        {

            reservationbutton.Width = 228+10;
            reservationbutton.Height = 146+10;
        }

        private void reservationbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            reservationbutton.Width = 228 ;
            reservationbutton.Height = 146;
        }

        private void flightsbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            flightsbutton.Width = 228 + 10;
            flightsbutton.Height = 146 + 10;
        }

        private void flightsbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            flightsbutton.Width = 228;
            flightsbutton.Height = 146;
        }

        private void routesbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            routesbutton.Width = 228 + 10;
            routesbutton.Height = 146 + 10;
        }

        private void routesbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            routesbutton.Width = 228 ;
            routesbutton.Height = 146 ;
        }

        private void empbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            empbutton.Width = 353 + 10;
            empbutton.Height = 166 + 10;
        }

        private void empbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            empbutton.Width = 353;
            empbutton.Height = 166;
        }

        private void adminbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            adminbutton.Width = 264 + 10;
            adminbutton.Height = 166 + 10;
        }

        private void adminbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            adminbutton.Width = 264;
            adminbutton.Height = 166;
        }

        private void reservationbutton_Click(object sender, RoutedEventArgs e)
        {
            reservation r = new reservation();
            this.NavigationService.Navigate(r);
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            login l = new login();
            this.NavigationService.Navigate(l);
        }

        private void flightsbutton_Click(object sender, RoutedEventArgs e)
        {
            flight h = new flight();
            this.NavigationService.Navigate(h);
        }

        private void routesbutton_Click(object sender, RoutedEventArgs e)
        {
            route r = new route();
            this.NavigationService.Navigate(r);
        }

        private void empbutton_Click(object sender, RoutedEventArgs e)
        {
            employee e1 = new employee();
            this.NavigationService.Navigate(e1);
        }

        private void adminbutton_Click(object sender, RoutedEventArgs e)
        {
            admin a = new admin();
            this.NavigationService.Navigate(a);
        }

        private void reports_MouseEnter(object sender, MouseEventArgs e)
        {
            reports.Width = 124 + 10;
            reports.Height = 166 + 10;
        }

        private void reports_MouseLeave(object sender, MouseEventArgs e)
        {
            reports.Width = 124 ;
            reports.Height = 166 ;
        }

        private void reports_Click(object sender, RoutedEventArgs e)
        {
            reportform rf = new reportform();
            rf.Show();
        }

      

     

        
    }
}
