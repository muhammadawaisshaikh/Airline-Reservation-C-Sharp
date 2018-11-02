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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lt1.Text == "" || lt2.Password == "")
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                try
                {

                    airlinqDataContext log = new airlinqDataContext();
        
                    var check = from n in log.admindbs
                                where n.name == lt1.Text && n.pass == lt2.Password
                                select n;

                    foreach (var c in check)
                    {
                        MessageBox.Show(" Admin Logined Successfully");
                        home h = new home();
                        this.NavigationService.Navigate(h);
                    }

                }
                catch
                {
                    MessageBox.Show(" Login Authority Failed  ");
                }
                
                
            }

        }
    }
}
